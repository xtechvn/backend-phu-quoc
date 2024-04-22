using Aspose.Cells;
using DAL;
using DAL.Invoice;
using DAL.Report;
using Entities.ConfigModels;
using Entities.Models;
using Entities.ViewModels;
using Entities.ViewModels.Report;
using Microsoft.Extensions.Options;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;

namespace Repositories.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly UserDAL userDAL;
        private readonly InvoiceRequestDAL invoiceRequestDAL;
        private readonly InvoiceDAL invoiceDAL;
        private readonly OrderDAL orderDal;
        private readonly OperatorReportDAL operatorReportDAL;
        private readonly DepartmentDAL departmentDAL;
        private readonly string _UrlStaticImage;

        public ReportRepository(IOptions<DataBaseConfig> dataBaseConfig, IOptions<DomainConfig> domainConfig)
        {
            orderDal = new OrderDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
            operatorReportDAL = new OperatorReportDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
            userDAL = new UserDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
            invoiceRequestDAL = new InvoiceRequestDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
            invoiceDAL = new InvoiceDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
            departmentDAL = new DepartmentDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
            _UrlStaticImage = domainConfig.Value.ImageStatic;

        }
        public async Task<GenericViewModel<OperatorReportViewModel>> GetOperatorReport(OperatorReportSearchModel searchModel, int currentPage = 1, int pageSize = 20)
        {
            List<int> order_status_finish = new List<int>() {
                    (int)OrderStatus.FINISHED,
                };
            List<int> order_status_not_finish = new List<int>() {
                    (int)OrderStatus.ACCOUNTANT_DECLINE,
                    (int)OrderStatus.CONFIRMED_SALE,
                    (int)OrderStatus.CREATED_ORDER,
                    (int)OrderStatus.OPERATOR_DECLINE,
                    (int)OrderStatus.WAITING_FOR_ACCOUNTANT,
                    (int)OrderStatus.WAITING_FOR_OPERATOR
                };
            try
            {
                if (currentPage <= 0) currentPage = 1;
                if (pageSize <= 0) pageSize = 20;
                if (searchModel.Branch <= 0) searchModel.Branch = null;
                if (searchModel == null) searchModel = new OperatorReportSearchModel();
                switch (searchModel.OrderStatus.Trim())
                {

                    case "1":
                        {
                            searchModel.OrderStatus = string.Join(",", order_status_finish);

                        }
                        break;
                    case "2":
                        {
                            searchModel.OrderStatus = string.Join(",", order_status_not_finish);

                        }
                        break;
                    default:
                        {
                            searchModel.OrderStatus = string.Join(",", order_status_finish) + "," + string.Join(",", order_status_not_finish);
                        }
                        break;
                }
                if (searchModel.InvoiceStatus != null)
                {
                    switch (searchModel.InvoiceStatus.Trim())
                    {

                        case "1":
                            {

                            }
                            break;
                        case "2":
                            {
                                searchModel.ExportDateFrom = null;
                                searchModel.ExportDateTo = null;
                            }
                            break;
                        default:
                            {
                                searchModel.InvoiceStatus = null;
                                searchModel.ExportDateFrom = null;
                                searchModel.ExportDateTo = null;
                            }
                            break;
                    }
                }
                if (searchModel.DepartmentId!=null && searchModel.DepartmentId <= 0) searchModel.DepartmentId = null;
                if (searchModel.DepartmentId == null) searchModel.DepartmentIdSearch = null;
                else
                {
                    searchModel.DepartmentIdSearch = string.Join(",", await departmentDAL.GetAllDepartmentByParentDepartmentId((int)searchModel.DepartmentId));
                }
                var model = new GenericViewModel<OperatorReportViewModel>();
                var data_table = operatorReportDAL.GetOperatorReport(searchModel, currentPage, pageSize);
                if (data_table != null && data_table.Rows != null && data_table.Rows.Count > 0)
                {
                    model.ListData = data_table.ToList<OperatorReportViewModel>();
                    model.CurrentPage = currentPage;
                    model.TotalRecord = model.ListData[0].TotalRow;
                    model.CurrentPage = currentPage;
                    model.PageSize = pageSize;
                    model.TotalPage = (model.ListData[0].TotalRow / (int)model.PageSize) + ((model.ListData[0].TotalRow % (int)model.PageSize) > 0 ? 1 : 0);
                }
                return model;
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetOperatorReport - ReportRepository: " + ex);
            }
            return new GenericViewModel<OperatorReportViewModel>();

        }
        public async Task<SumOperatorReportViewModel> GetSumOperatorReport(OperatorReportSearchModel searchModel)
        {
            try
            {
                
                var data_table = operatorReportDAL.GetSumOperatorReport(searchModel);
                if (data_table!=null && data_table.Rows != null && data_table.Rows.Count > 0)
                {
                    var data = data_table.ToList<SumOperatorReportViewModel>();
                    return data[0];
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetOperatorReport - ReportRepository: " + ex);
            }
            return new SumOperatorReportViewModel();

        }
        public async Task<string> ExportOperatorExcel(GenericViewModel<OperatorReportViewModel> model, string file_path)
        {
          
            try
            {
                string full_path = Directory.GetCurrentDirectory() + file_path;
                if (!file_path.Contains("wwwroot"))
                {
                    full_path = Directory.GetCurrentDirectory() + @"\wwwroot" + file_path;
                }
                try
                {
                    File.Delete(full_path);
                }
                catch { }
                if (model != null && model.ListData.Count > 0)
                {
                    Workbook wb = new Workbook();
                    Worksheet ws = wb.Worksheets[0];
                    ws.Name = "Phát sinh đơn hàng";
                    Cells cell = ws.Cells;

                    var range = ws.Cells.CreateRange(0, 0, 1, 1);
                    StyleFlag st = new StyleFlag();
                    st.All = true;
                    Style style = ws.Cells["A1"].GetStyle();

                    #region Header
                    range = cell.CreateRange(0, 0, 2, 23);
                    style = ws.Cells["A1"].GetStyle();
                    style.Font.IsBold = true;
                    style.IsTextWrapped = true;
                    //style.ForegroundColor = Color.FromArgb(33, 88, 103);
                    //style.BackgroundColor = Color.FromArgb(33, 88, 103);
                    style.Pattern = BackgroundType.Solid;
                    //style.Font.Color = Color.White;
                    style.VerticalAlignment = TextAlignmentType.Center;
                    style.HorizontalAlignment = TextAlignmentType.Center;
                    style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.TopBorder].Color = Color.Black;
                    style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.BottomBorder].Color = Color.Black;
                    style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.LeftBorder].Color = Color.Black;
                    style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.RightBorder].Color = Color.Black;
                    range.ApplyStyle(style, st);

                    // Set column width
                    cell.SetColumnWidth(0, 8);
                    cell.SetColumnWidth(1, 20);
                    cell.SetColumnWidth(2, 40);
                    cell.SetColumnWidth(3, 20);
                    cell.SetColumnWidth(4, 20);
                    cell.SetColumnWidth(5, 30);
                    cell.SetColumnWidth(6, 30);
                    cell.SetColumnWidth(7, 25);
                    cell.SetColumnWidth(8, 25);
                    cell.SetColumnWidth(9, 25);
                    cell.SetColumnWidth(10, 25);
                    cell.SetColumnWidth(11, 25);
                    cell.SetColumnWidth(12, 25);
                    cell.SetColumnWidth(13, 25);
                    cell.SetColumnWidth(14, 25);
                    cell.SetColumnWidth(15, 25);
                    cell.SetColumnWidth(16, 25);
                    cell.SetColumnWidth(17, 50);
                    cell.SetColumnWidth(18, 75);
                    cell.SetColumnWidth(19, 25);
                    cell.SetColumnWidth(20, 75);
                    cell.SetColumnWidth(21, 25);
                    cell.SetColumnWidth(22, 50);


                    // Set header value
                    ws.Cells["G1"].PutValue("Doanh thu (Tổng thu của khách hàng)");
                    cell.Merge(0, 5, 1, 3);
                    ws.Cells["J1"].PutValue("Giá vốn  (Tổng chi cho nhà cung cấp)");
                    cell.Merge(0, 8, 1, 3);

                    ws.Cells["A2"].PutValue("STT");
                    ws.Cells["B2"].PutValue("Phòng ban");
                    ws.Cells["C2"].PutValue("Mã đơn hàng");
                    ws.Cells["D2"].PutValue("Ngày in");
                    ws.Cells["E2"].PutValue("Ngày out");
                  

                    ws.Cells["L2"].PutValue("Hoa hồng CTV");
                    ws.Cells["M2"].PutValue("Lợi nhuận (có VAT)");
                    ws.Cells["N2"].PutValue("Trạng thái");
                    ws.Cells["O2"].PutValue("Số hóa đơn");
                    ws.Cells["P2"].PutValue("Ngày xuất hóa đơn");
                    ws.Cells["Q2"].PutValue("Người phụ trách chính");
                    ws.Cells["R2"].PutValue("Điều hành");
                    ws.Cells["S2"].PutValue("Ngân hàng nhận tiền");
                    ws.Cells["T2"].PutValue("Mã khách hàng");
                    ws.Cells["U2"].PutValue("Nhãn đơn hàng");
                    ws.Cells["V2"].PutValue("Chi nhánh");
                    ws.Cells["W2"].PutValue("Tên khách hàng");
                    
                    cell.Merge(0, 0, 2, 1);
                    cell.Merge(0, 1, 2, 1);
                    cell.Merge(0, 2, 2, 1);
                    cell.Merge(0, 3, 2, 1);
                    cell.Merge(0, 4, 2, 1);
                    
                    cell.Merge(0, 11, 2, 1);
                    cell.Merge(0, 12, 2, 1);
                    cell.Merge(0, 13, 2, 1);
                    cell.Merge(0, 14, 2, 1);
                    cell.Merge(0, 15, 2, 1);
                    cell.Merge(0, 16, 2, 1);
                    cell.Merge(0, 17, 2, 1);
                    cell.Merge(0, 18, 2, 1);
                    cell.Merge(0, 19, 2, 1);
                    cell.Merge(0, 20, 2, 1);
                    cell.Merge(0, 21, 2, 1);
                    cell.Merge(0, 22, 2, 1);

                    ws.Cells["F2"].PutValue("Tổng tiền");
                    ws.Cells["G2"].PutValue("Đã thu");
                    ws.Cells["H2"].PutValue("Còn phải thu");

                    ws.Cells["I2"].PutValue("Tổng tiền");
                    ws.Cells["J2"].PutValue("Đã thanh toán");
                    ws.Cells["K2"].PutValue(" Còn phải thanh toán");
                    #endregion

                    #region Body

                    range = cell.CreateRange(1, 0, model.ListData.Count + 1, 23);
                    style = ws.Cells["A3"].GetStyle();
                    style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.TopBorder].Color = Color.Black;
                    style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.BottomBorder].Color = Color.Black;
                    style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.LeftBorder].Color = Color.Black;
                    style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.RightBorder].Color = Color.Black;
                    style.VerticalAlignment = TextAlignmentType.Center;
                    range.ApplyStyle(style, st);

                    Style alignCenterStyle = ws.Cells["A3"].GetStyle();
                    alignCenterStyle.HorizontalAlignment = TextAlignmentType.Center;

                    Style alignRightStyle = ws.Cells["A3"].GetStyle();
                    alignCenterStyle.HorizontalAlignment = TextAlignmentType.Right;
                    alignCenterStyle.VerticalAlignment = TextAlignmentType.Center;
                    ws.Cells["F2"].SetStyle(alignRightStyle);
                    ws.Cells["G2"].SetStyle(alignRightStyle);
                    ws.Cells["H2"].SetStyle(alignRightStyle);

                    ws.Cells["I2"].SetStyle(alignRightStyle);
                    ws.Cells["J2"].SetStyle(alignRightStyle);
                    ws.Cells["K2"].SetStyle(alignRightStyle);

                    Style numberStyle = ws.Cells["A3"].GetStyle();
                    numberStyle.Number = 3;
                    numberStyle.HorizontalAlignment = TextAlignmentType.Right;
                    numberStyle.VerticalAlignment = TextAlignmentType.Center;

                    int RowIndex = 2;

                    foreach (var item in model.ListData)
                    {

                        RowIndex++;
                        ws.Cells["A" + RowIndex].PutValue(RowIndex - 2);
                        ws.Cells["A" + RowIndex].SetStyle(alignCenterStyle);

                        ws.Cells["B" + RowIndex].PutValue(item.DepartmentName);
                        ws.Cells["C" + RowIndex].PutValue(item.OrderNo);

                        ws.Cells["D" + RowIndex].PutValue(item.StartDate.ToString("dd/MM/yyyy HH:mm"));
                        ws.Cells["E" + RowIndex].PutValue(item.EndDate.ToString("dd/MM/yyyy HH:mm"));

                        ws.Cells["F" + RowIndex].PutValue(item.Amount);
                        ws.Cells["G" + RowIndex].PutValue(item.AmountPay == null ? 0 : ((double)item.AmountPay));
                        ws.Cells["H" + RowIndex].PutValue(item.AmountRemain == null ? item.Amount : ((double)item.AmountRemain));

                        ws.Cells["I" + RowIndex].PutValue(item.Price == null ? 0 : ((double)item.Price));
                        ws.Cells["J" + RowIndex].PutValue(item.PricePay == null ? 0 : ((double)item.PricePay));
                        double item_price_remain = 0;
                        if (item.PriceRemain == null)
                        {
                            item_price_remain = (item.Price == null ? 0 : (double)item.Price);
                        }
                        else
                        {
                            item_price_remain = (double)item.PriceRemain;

                        }
                        ws.Cells["K" + RowIndex].PutValue(item_price_remain);

                        ws.Cells["L" + RowIndex].PutValue(item.Comission == null ? 0 : ((double)item.Comission));
                        ws.Cells["M" + RowIndex].PutValue(item.Profit == null ? 0 : ((double)item.Profit));

                        ws.Cells["N" + RowIndex].PutValue(item.OrderStatusName != null ? item.OrderStatusName : "");
                        ws.Cells["O" + RowIndex].PutValue(item.InvoiceNo != null ? item.InvoiceNo : "");
                        ws.Cells["P" + RowIndex].PutValue(item.ExportDate == null ? "" : ((DateTime)item.ExportDate).ToString("dd/MM/yyyy HH:mm"));

                        ws.Cells["Q" + RowIndex].PutValue(item.FullName != null ? item.FullName : "");
                        ws.Cells["R" + RowIndex].PutValue(item.OperatorName != null ? item.OperatorName : "");
                        ws.Cells["S" + RowIndex].PutValue(item.BankId != null ? item.BankId.Replace(",", " ") + " - " + item.AccountNumber : "");
                        ws.Cells["T" + RowIndex].PutValue(item.ClientCode ?? "");
                        ws.Cells["U" + RowIndex].PutValue(item.Label != null ? item.Label : "");
                        ws.Cells["V" + RowIndex].PutValue(item.BranchName != null ? item.BranchName : "");
                        ws.Cells["W" + RowIndex].PutValue(item.ClientName ?? "");

                        ws.Cells["F" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["G" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["H" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["I" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["J" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["K" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["L" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["M" + RowIndex].SetStyle(numberStyle);

                    }
                    // ws.AutoFitColumns();
                    ws.Cells.InsertColumn(2);
                    ws.Cells.CopyColumn(ws.Cells, ws.Cells.Columns[22].Index, ws.Cells.Columns[2].Index);
                    ws.Cells.DeleteColumn(22);

                    ws.Cells.InsertColumn(3);
                    ws.Cells.CopyColumn(ws.Cells, ws.Cells.Columns[22].Index, ws.Cells.Columns[3].Index);
                    ws.Cells.DeleteColumn(22);

                    ws.Cells.InsertColumn(4);
                    ws.Cells.CopyColumn(ws.Cells, ws.Cells.Columns[22].Index, ws.Cells.Columns[4].Index);
                    ws.Cells.DeleteColumn(22);

                    ws.Cells.InsertColumn(5);
                    ws.Cells.CopyColumn(ws.Cells, ws.Cells.Columns[23].Index, ws.Cells.Columns[5].Index);
                    ws.Cells.DeleteColumn(23);
                    #endregion
                    wb.Save(full_path);
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetOperatorReport - ReportRepository: " + ex);
            }
            return file_path;
        }
        public async Task<GenericViewModel<ReportClientDebtViewModel>> GetTotalDebtRevenueByClient(ReportClientDebtSearchModel searchModel)
        {
          
            try
            {
                if (searchModel == null) searchModel = new ReportClientDebtSearchModel();

                if (searchModel.PageIndex==null || searchModel.PageIndex <= 0) searchModel.PageIndex = 1;
                if (searchModel.PageSize == null || searchModel.PageSize <= 0) searchModel.PageSize = 20;
                
                var model = new GenericViewModel<ReportClientDebtViewModel>();
                var data_table = operatorReportDAL.GetTotalDebtRevenueByClient(searchModel);
                if (data_table != null && data_table.Rows != null && data_table.Rows.Count > 0)
                {
                    model.ListData = data_table.ToList<ReportClientDebtViewModel>();
                    model.CurrentPage = (int)searchModel.PageIndex;
                    model.TotalRecord = model.ListData[0].TotalRow;
                    model.PageSize = (int)searchModel.PageSize;
                    model.TotalPage = (model.ListData[0].TotalRow / (int)model.PageSize) + ((model.ListData[0].TotalRow % (int)model.PageSize) > 0 ? 1 : 0);
                }
                return model;
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetTotalDebtRevenueByClient - ReportRepository: " + ex);
            }
            return new GenericViewModel<ReportClientDebtViewModel>();

        }

        public async Task<string> ExportTotalDebtRevenueByClient(GenericViewModel<ReportClientDebtViewModel> model, string file_path)
        {

            try
            {
                string full_path = Directory.GetCurrentDirectory() + file_path;
                if (!file_path.Contains("wwwroot"))
                {
                    full_path = Directory.GetCurrentDirectory() + @"\wwwroot" + file_path;
                }
                try
                {
                    File.Delete(full_path);
                }
                catch { }
                if (model != null && model.ListData.Count > 0)
                {
                    Workbook wb = new Workbook();
                    Worksheet ws = wb.Worksheets[0];
                    ws.Name = "Nợ phải thu của KH";
                    Cells cell = ws.Cells;

                    var range = ws.Cells.CreateRange(0, 0, 1, 1);
                    StyleFlag st = new StyleFlag();
                    st.All = true;
                    Style style = ws.Cells["A1"].GetStyle();

                    #region Header
                    range = cell.CreateRange(0, 0, 2, 9);
                    style = ws.Cells["A1"].GetStyle();
                    style.Font.IsBold = true;
                    style.IsTextWrapped = true;
                    //style.ForegroundColor = Color.FromArgb(33, 88, 103);
                    //style.BackgroundColor = Color.FromArgb(33, 88, 103);
                    style.Pattern = BackgroundType.Solid;
                    //style.Font.Color = Color.White;
                    style.VerticalAlignment = TextAlignmentType.Center;
                    style.HorizontalAlignment = TextAlignmentType.Center;
                    style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.TopBorder].Color = Color.Black;
                    style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.BottomBorder].Color = Color.Black;
                    style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.LeftBorder].Color = Color.Black;
                    style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.RightBorder].Color = Color.Black;
                    range.ApplyStyle(style, st);

                    // Set column width
                    cell.SetColumnWidth(0, 8);
                    cell.SetColumnWidth(1, 20);
                    cell.SetColumnWidth(2, 40);
                    cell.SetColumnWidth(3, 20);
                    cell.SetColumnWidth(4, 20);
                    cell.SetColumnWidth(5, 30);
                    cell.SetColumnWidth(6, 30);
                    cell.SetColumnWidth(7, 25);
                    cell.SetColumnWidth(8, 25);


                    // Set header value
                    ws.Cells["D1"].PutValue("Số dư đầu kỳ");
                    cell.Merge(0, 3, 1, 2);
                    ws.Cells["F1"].PutValue("Phát sinh trong kỳ");
                    cell.Merge(0, 5, 1, 2);
                    ws.Cells["H1"].PutValue("Số dư cuối kỳ");
                    cell.Merge(0, 7, 1, 2);

                    ws.Cells["A2"].PutValue("STT");
                    ws.Cells["B2"].PutValue("Mã khách hàng");
                    ws.Cells["C2"].PutValue("Tên khách hàng");



                    ws.Cells["D2"].PutValue("Nợ");
                    ws.Cells["E2"].PutValue("Có");

                    ws.Cells["F2"].PutValue("Nợ");
                    ws.Cells["G2"].PutValue("Có");

                    ws.Cells["H2"].PutValue("Nợ");
                    ws.Cells["I2"].PutValue("Có");


                    cell.Merge(0, 0, 2, 1);
                    cell.Merge(0, 1, 2, 1);
                    cell.Merge(0, 2, 2, 1);
      
                    #endregion

                    #region Body

                    range = cell.CreateRange(1, 0, model.ListData.Count + 1, 9);
                    style = ws.Cells["A3"].GetStyle();
                    style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.TopBorder].Color = Color.Black;
                    style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.BottomBorder].Color = Color.Black;
                    style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.LeftBorder].Color = Color.Black;
                    style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.RightBorder].Color = Color.Black;
                    style.VerticalAlignment = TextAlignmentType.Center;
                    range.ApplyStyle(style, st);

                    Style alignCenterStyle = ws.Cells["A3"].GetStyle();
                    alignCenterStyle.HorizontalAlignment = TextAlignmentType.Center;
                    alignCenterStyle.VerticalAlignment = TextAlignmentType.Center;

                    Style alignRightStyle = ws.Cells["A3"].GetStyle();
                    alignRightStyle.HorizontalAlignment = TextAlignmentType.Right;
                    alignRightStyle.VerticalAlignment = TextAlignmentType.Center;


                    ws.Cells["D2"].SetStyle(alignRightStyle);
                    ws.Cells["E2"].SetStyle(alignRightStyle);
                    ws.Cells["F2"].SetStyle(alignRightStyle);

                    ws.Cells["G2"].SetStyle(alignRightStyle);
                    ws.Cells["H2"].SetStyle(alignRightStyle);
                    ws.Cells["I2"].SetStyle(alignRightStyle);

                    Style numberStyle = ws.Cells["A3"].GetStyle();
                    numberStyle.Number = 3;
                    numberStyle.HorizontalAlignment = TextAlignmentType.Right;
                    numberStyle.VerticalAlignment = TextAlignmentType.Center;

                    int RowIndex = 2;

                    foreach (var item in model.ListData)
                    {

                        RowIndex++;
                        ws.Cells["A" + RowIndex].PutValue(RowIndex - 2);
                        ws.Cells["A" + RowIndex].SetStyle(alignCenterStyle);

                        ws.Cells["B" + RowIndex].PutValue(item.ClientId);

                        ws.Cells["C" + RowIndex].PutValue(item.ClientName);
                        ws.Cells["C" + RowIndex].SetStyle(alignCenterStyle);


                        ws.Cells["D" + RowIndex].PutValue(item.AmountOpeningBalanceDebit == null ? 0 : ((double)item.AmountOpeningBalanceDebit));
                        ws.Cells["E" + RowIndex].PutValue(item.AmountOpeningBalanceCredit == null ? 0 : ((double)item.AmountOpeningBalanceCredit));

                        ws.Cells["F" + RowIndex].PutValue(item.AmountDebit == null ? 0 : ((double)item.AmountDebit));
                        ws.Cells["G" + RowIndex].PutValue(item.AmountCredit == null ? 0 : ((double)item.AmountCredit));
                        ws.Cells["H" + RowIndex].PutValue(item.AmountClosingBalanceDebit == null ? 0 : ((double)item.AmountClosingBalanceDebit));

                        ws.Cells["I" + RowIndex].PutValue(item.AmountClosingBalanceCredit == null ? 0 : ((double)item.AmountClosingBalanceCredit));


                        ws.Cells["D" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["E" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["F" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["G" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["H" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["I" + RowIndex].SetStyle(numberStyle);
                       

                    }
                    #endregion
                    wb.Save(full_path);
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("ExportTotalDebtRevenueByClient - ReportRepository: " + ex);
            }
            return file_path;
        }
        public async Task<GenericViewModel<ReportDetailClientDebtViewModel>> GetDetailDebtRevenueByClient(ReportDetailClientDebtSearchModel searchModel)
        {

            try
            {
                if (searchModel == null) searchModel = new ReportDetailClientDebtSearchModel();

                if ( searchModel.PageIndex <= 0) searchModel.PageIndex = 1;
                if ( searchModel.PageSize <= 0) searchModel.PageSize = 20;

                var model = new GenericViewModel<ReportDetailClientDebtViewModel>();
                var data_table = operatorReportDAL.GetDetailDebtRevenueByClient(searchModel);
                if (data_table != null && data_table.Rows != null && data_table.Rows.Count > 0)
                {
                    model.ListData = data_table.ToList<ReportDetailClientDebtViewModel>();
                    model.CurrentPage = (int)searchModel.PageIndex;
                    model.TotalRecord = model.ListData[0].TotalRow;
                    model.PageSize = (int)searchModel.PageSize;
                    model.TotalPage = (model.ListData[0].TotalRow / (int)model.PageSize) + ((model.ListData[0].TotalRow % (int)model.PageSize) > 0 ? 1 : 0);
                }
                return model;
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetDetailDebtRevenueByClient - ReportRepository: " + ex);
            }
            return new GenericViewModel<ReportDetailClientDebtViewModel>();

        }

        public async Task<string> ExportDetailDebtRevenueByClient(GenericViewModel<ReportDetailClientDebtViewModel> model, string file_path, ReportDetailClientDebtSearchModel searchModel)
        {

            try
            {
                
                string full_path = Directory.GetCurrentDirectory() + file_path;
                if (!file_path.Contains("wwwroot"))
                {
                    full_path = Directory.GetCurrentDirectory() + @"\wwwroot" + file_path;
                }
                try
                {
                    File.Delete(full_path);
                }
                catch { }
                if (model != null && model.ListData.Count > 0)
                {
                    Workbook wb = new Workbook();
                    Worksheet ws = wb.Worksheets[0];
                    ws.Name = "Chi tiết nợ phải thu";
                    Cells cell = ws.Cells;

                    var range = ws.Cells.CreateRange(0, 0, 1, 1);
                    StyleFlag st = new StyleFlag();
                    st.All = true;
                    Style style = ws.Cells["A1"].GetStyle();

                    #region Header
                    range = cell.CreateRange(0, 0, 2, 12);
                    style = ws.Cells["A1"].GetStyle();
                    style.Font.IsBold = true;
                    style.IsTextWrapped = true;
                    //style.ForegroundColor = Color.FromArgb(33, 88, 103);
                    //style.BackgroundColor = Color.FromArgb(33, 88, 103);
                    style.Pattern = BackgroundType.Solid;
                    //style.Font.Color = Color.White;
                    style.VerticalAlignment = TextAlignmentType.Center;
                    style.HorizontalAlignment = TextAlignmentType.Center;
                    style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.TopBorder].Color = Color.Black;
                    style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.BottomBorder].Color = Color.Black;
                    style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.LeftBorder].Color = Color.Black;
                    style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.RightBorder].Color = Color.Black;
                    range.ApplyStyle(style, st);

                    // Set column width
                    cell.SetColumnWidth(0, 8);
                    cell.SetColumnWidth(1, 20);
                    cell.SetColumnWidth(2, 20);
                    cell.SetColumnWidth(3, 20);
                    cell.SetColumnWidth(4, 20);
                    cell.SetColumnWidth(5, 30);
                    cell.SetColumnWidth(6, 30);
                    cell.SetColumnWidth(7, 25);
                    cell.SetColumnWidth(8, 15);
                    cell.SetColumnWidth(9, 15);
                    cell.SetColumnWidth(10, 15);
                    cell.SetColumnWidth(11, 15);


                    // Set header value
                    ws.Cells["A2"].PutValue("STT");
                    ws.Cells["B2"].PutValue("Ngày hạch toán");
                    ws.Cells["C2"].PutValue("Ngày chứng từ");
                    ws.Cells["D2"].PutValue("Số chứng từ");
                    ws.Cells["E2"].PutValue("Số hóa đơn");
                    ws.Cells["F2"].PutValue("Diễn giải");
                    ws.Cells["G2"].PutValue("TK công nợ");
                    ws.Cells["H2"].PutValue("TK đối ứng");

                    ws.Cells["I1"].PutValue("Phát sinh");
                    cell.Merge(0, 8, 1, 2);
                    ws.Cells["K1"].PutValue("Số dư");
                    cell.Merge(0, 10, 1, 2);

                    ws.Cells["I2"].PutValue("Nợ");
                    ws.Cells["J2"].PutValue("Có");

                    ws.Cells["K2"].PutValue("Nợ");
                    ws.Cells["L2"].PutValue("Có");


                    cell.Merge(0, 0, 2, 1);
                    cell.Merge(0, 1, 2, 1);
                    cell.Merge(0, 2, 2, 1);
                    cell.Merge(0, 3, 2, 1);
                    cell.Merge(0, 4, 2, 1);
                    cell.Merge(0, 5, 2, 1);
                    cell.Merge(0, 6, 2, 1);
                    cell.Merge(0, 7, 2, 1);

                    #endregion

                    #region Body

                    range = cell.CreateRange(1, 0, model.ListData.Count + 1, 12);
                    style = ws.Cells["A3"].GetStyle();
                    style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.TopBorder].Color = Color.Black;
                    style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.BottomBorder].Color = Color.Black;
                    style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.LeftBorder].Color = Color.Black;
                    style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.RightBorder].Color = Color.Black;
                    style.VerticalAlignment = TextAlignmentType.Center;
                    range.ApplyStyle(style, st);

                    Style alignCenterStyle = ws.Cells["A3"].GetStyle();
                    alignCenterStyle.HorizontalAlignment = TextAlignmentType.Center;
                    alignCenterStyle.VerticalAlignment = TextAlignmentType.Center;

                    Style alignRightStyle = ws.Cells["A3"].GetStyle();
                    alignRightStyle.HorizontalAlignment = TextAlignmentType.Right;
                    alignRightStyle.VerticalAlignment = TextAlignmentType.Center;


                    ws.Cells["I2"].SetStyle(alignRightStyle);
                    ws.Cells["J2"].SetStyle(alignRightStyle);
                    ws.Cells["K2"].SetStyle(alignRightStyle);
                    ws.Cells["L2"].SetStyle(alignRightStyle);


                    Style numberStyle = ws.Cells["A3"].GetStyle();
                    numberStyle.Number = 3;
                    numberStyle.HorizontalAlignment = TextAlignmentType.Right;
                    numberStyle.VerticalAlignment = TextAlignmentType.Center;

                    int RowIndex = 2;
                    double opening_credit = searchModel.OpeningCreditValue;
                    foreach (var item in model.ListData)
                    {

                        RowIndex++;
                        ws.Cells["A" + RowIndex].PutValue(RowIndex - 2);
                        ws.Cells["A" + RowIndex].SetStyle(alignCenterStyle);

                        ws.Cells["B" + RowIndex].PutValue(item.CreatedDate.ToString("dd/MM/yyyy HH:mm"));
                        ws.Cells["B" + RowIndex].SetStyle(alignCenterStyle);

                        ws.Cells["C" + RowIndex].PutValue(item.CreatedDate.ToString("dd/MM/yyyy HH:mm"));
                        ws.Cells["C" + RowIndex].SetStyle(alignCenterStyle);


                        ws.Cells["D" + RowIndex].PutValue(item.LicenceNo);
                        ws.Cells["E" + RowIndex].PutValue(item.BillNo);

                        ws.Cells["F" + RowIndex].PutValue(item.Description);
                        ws.Cells["G" + RowIndex].PutValue(item.DebtAccount);
                        ws.Cells["H" + RowIndex].PutValue(item.CorrespondingAccount);

                        opening_credit = opening_credit + (item.AmountDebit != null ? (double)item.AmountDebit : 0) - (item.AmountCredit != null ? (double)item.AmountCredit : 0);

                        ws.Cells["I" + RowIndex].PutValue((item.AmountDebit != null ? (double)item.AmountDebit : 0).ToString("N0"));
                        ws.Cells["J" + RowIndex].PutValue((item.AmountCredit != null ? (double)item.AmountCredit : 0).ToString("N0"));
                        ws.Cells["K" + RowIndex].PutValue(opening_credit.ToString("N0"));
                        ws.Cells["L" + RowIndex].PutValue("");


                        ws.Cells["I" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["J" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["K" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["L" + RowIndex].SetStyle(numberStyle);

                    }
                    #endregion
                    wb.Save(full_path);
                }
                
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("ExportDetailDebtRevenueByClient - ReportRepository: " + ex);
            }
            return file_path;
        }
        public async Task<GenericViewModel<WSReportViewModel>> GetWSOperatorReport(WSReportSearchModel searchModel)
        {

            try
            {
                if (searchModel == null) searchModel = new WSReportSearchModel();
                var model = new GenericViewModel<WSReportViewModel>();
                var data_table = operatorReportDAL.GetWSOperatorReport(searchModel);
                if (data_table != null && data_table.Rows != null && data_table.Rows.Count > 0)
                {
                    model.ListData = data_table.ToList<WSReportViewModel>();
                    model.TotalRecord = model.ListData.Count;
                    model.TotalPage = 1;
                }
                return model;
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetTotalDebtRevenueByClient - ReportRepository: " + ex);
            }
            return new GenericViewModel<WSReportViewModel>();

        }
        public async Task<string> ExportWSExcel(GenericViewModel<WSReportViewModel> model, WSReportSearchModel searchModel, string file_path)
        {

            try
            {
                string full_path = Directory.GetCurrentDirectory() + file_path;
                if (!file_path.Contains("wwwroot"))
                {
                    full_path = Directory.GetCurrentDirectory() + @"\wwwroot" + file_path;
                }
                try
                {
                    File.Delete(full_path);
                }
                catch { }
                if (model != null && model.ListData.Count > 0)
                {
                    Workbook wb = new Workbook();
                    Worksheet ws = wb.Worksheets[0];
                    ws.Name = "Phát sinh dịch vụ";
                    Cells cell = ws.Cells;

                    var range = ws.Cells.CreateRange(0, 0, 1, 1);
                    StyleFlag st = new StyleFlag();
                    st.All = true;
                    Style style = ws.Cells["A1"].GetStyle();

                    #region Header
                    range = cell.CreateRange(0, 0, 2, 15);
                    style = ws.Cells["A1"].GetStyle();
                    style.Font.IsBold = true;
                    style.IsTextWrapped = true;
                    //style.ForegroundColor = Color.FromArgb(33, 88, 103);
                    //style.BackgroundColor = Color.FromArgb(33, 88, 103);
                    style.Pattern = BackgroundType.Solid;
                    //style.Font.Color = Color.White;
                    style.VerticalAlignment = TextAlignmentType.Center;
                    style.HorizontalAlignment = TextAlignmentType.Center;
                    style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.TopBorder].Color = Color.Black;
                    style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.BottomBorder].Color = Color.Black;
                    style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.LeftBorder].Color = Color.Black;
                    style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.RightBorder].Color = Color.Black;
                    range.ApplyStyle(style, st);

                    // Set column width
                    cell.SetColumnWidth(0, 25);
                    cell.SetColumnWidth(1, 25);
                    cell.SetColumnWidth(2, 25);
                    cell.SetColumnWidth(3, 25);
                    cell.SetColumnWidth(4, 25);
                    cell.SetColumnWidth(5, 25);
                    cell.SetColumnWidth(6, 25);
                    cell.SetColumnWidth(7, 25);
                    cell.SetColumnWidth(8, 25);
                    cell.SetColumnWidth(9, 25);
                    cell.SetColumnWidth(10, 25);
                    cell.SetColumnWidth(11, 25);
                    cell.SetColumnWidth(12, 25);
                    cell.SetColumnWidth(13, 25);
                    cell.SetColumnWidth(14, 25);
                    cell.SetColumnWidth(15, 25);

                    // Set header value

                    ws.Cells["A1"].PutValue("Mã khách hàng");
                    ws.Cells["B1"].PutValue("Nhãn đơn");
                    ws.Cells["C1"].PutValue("Ngày sử dụng");
                    ws.Cells["D1"].PutValue("Tên đại lý");
                    ws.Cells["E1"].PutValue("Số Conf No.");
                    ws.Cells["F1"].PutValue("Số phòng");
                    ws.Cells["G1"].PutValue("Số Series");
                    ws.Cells["H1"].PutValue("Tên sản phẩm");
                    ws.Cells["I1"].PutValue("Số lượng");
                    ws.Cells["J1"].PutValue("Đơn giá");
                    ws.Cells["K1"].PutValue("Thành tiền");
                    ws.Cells["L1"].PutValue("Trước VAT");
                    ws.Cells["M1"].PutValue("Hoa hồng" + (searchModel.VAT <= 0 ? " "+ (Math.Round(searchModel.VAT *100).ToString("N0") + "%") : " "));
                    ws.Cells["N1"].PutValue("Ghi chú" );
                    ws.Cells["O1"].PutValue("Tên khách hàng");

                    #endregion

                    #region Body

                    range = cell.CreateRange(1, 0, model.ListData.Count, 15);
                    style = ws.Cells["A3"].GetStyle();
                    style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.TopBorder].Color = Color.Black;
                    style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.BottomBorder].Color = Color.Black;
                    style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.LeftBorder].Color = Color.Black;
                    style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.RightBorder].Color = Color.Black;
                    style.VerticalAlignment = TextAlignmentType.Center;
                    range.ApplyStyle(style, st);

                    Style alignCenterStyle = ws.Cells["A3"].GetStyle();
                    alignCenterStyle.HorizontalAlignment = TextAlignmentType.Center;

                    Style alignRightStyle = ws.Cells["A3"].GetStyle();
                    alignCenterStyle.HorizontalAlignment = TextAlignmentType.Right;
                    alignCenterStyle.VerticalAlignment = TextAlignmentType.Center;
                   
                    Style numberStyle = ws.Cells["A3"].GetStyle();
                    numberStyle.Number = 3;
                    numberStyle.HorizontalAlignment = TextAlignmentType.Right;
                    numberStyle.VerticalAlignment = TextAlignmentType.Center;

                    int RowIndex = 1;

                    foreach (var item in model.ListData)
                    {
                        RowIndex++;
                        ws.Cells["A" + RowIndex].PutValue(item.ClientCode);
                        ws.Cells["A" + RowIndex].SetStyle(alignCenterStyle);

                        ws.Cells["B" + RowIndex].PutValue(item.Label);
                        ws.Cells["B" + RowIndex].SetStyle(alignCenterStyle);

                        ws.Cells["C" + RowIndex].PutValue(item.StartDate.ToString("dd/MM/yyyy"));

                        ws.Cells["D" + RowIndex].PutValue(item.ClientName);

                        ws.Cells["E" + RowIndex].PutValue(item.ConfNo);
                        ws.Cells["F" + RowIndex].PutValue(item.RoomNo);
                        ws.Cells["G" + RowIndex].PutValue(item.SerialNo);

                        ws.Cells["H" + RowIndex].PutValue(item.ProductName);

                        ws.Cells["I" + RowIndex].PutValue(item.Quantity.ToString("N0"));
                        ws.Cells["J" + RowIndex].PutValue(item.BasePrice.ToString("N0"));
                        ws.Cells["K" + RowIndex].PutValue(item.Amount.ToString("N0"));

                        ws.Cells["L" + RowIndex].PutValue((item.AmountVat).ToString("N0"));
                        ws.Cells["M" + RowIndex].PutValue((item.Commission != null ? (double)item.Commission : 0).ToString("N0"));

                        ws.Cells["N" + RowIndex].PutValue(item.Note);
                        ws.Cells["O" + RowIndex].PutValue(item.EndUserName);

                        ws.Cells["I" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["J" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["K" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["L" + RowIndex].SetStyle(numberStyle);
                        ws.Cells["M" + RowIndex].SetStyle(numberStyle);
                    }

                    #endregion
                    ws.Cells.InsertColumn(4);
                    ws.Cells.CopyColumn(ws.Cells, ws.Cells.Columns[15].Index, ws.Cells.Columns[4].Index);
                    ws.Cells.DeleteColumn(15);


                    wb.Save(full_path);
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("ExportWSExcel - ReportRepository: " + ex);
            }
            return file_path;
        }

        public async Task<string> ExportWSTotalExcel(GenericViewModel<WSReportViewModel> model, WSReportSearchModel searchModel, List<AllCode> ws_type, string file_path)
        {

            try
            {
                string full_path = Directory.GetCurrentDirectory() + file_path;
                if (!file_path.Contains("wwwroot"))
                {
                    full_path = Directory.GetCurrentDirectory() + @"\wwwroot" + file_path;
                }
                try
                {
                    File.Delete(full_path);
                }
                catch { }
                if (model != null && model.ListData.Count > 0)
                {
                    var list_total_report = await GetWSTotalReportFromData(model);

                    Workbook wb = new Workbook();
                    Worksheet ws = wb.Worksheets[0];
                    ws.Name = "Dịch vụ TTB";
                    Cells cell = ws.Cells;

                    var range = ws.Cells.CreateRange(0, 0, 1, 1);
                    StyleFlag st = new StyleFlag();
                    st.All = true;
                    Style style = ws.Cells["A1"].GetStyle();
                    int cell_id_first_row = 2;

                    foreach (var type in ws_type)
                    {
                        cell_id_first_row++;
                        cell_id_first_row++;

                    }
                    int max_column = cell_id_first_row+2;
                    cell_id_first_row = 2;
                    #region Header
                    range = cell.CreateRange(0, 0, 2, max_column);
                    style = ws.Cells["A1"].GetStyle();
                    style.Font.IsBold = true;
                    style.IsTextWrapped = true;
                    //style.ForegroundColor = Color.FromArgb(33, 88, 103);
                    //style.BackgroundColor = Color.FromArgb(33, 88, 103);
                    style.Pattern = BackgroundType.Solid;
                    //style.Font.Color = Color.White;
                    style.VerticalAlignment = TextAlignmentType.Center;
                    style.HorizontalAlignment = TextAlignmentType.Center;
                    style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.TopBorder].Color = Color.Black;
                    style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.BottomBorder].Color = Color.Black;
                    style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.LeftBorder].Color = Color.Black;
                    style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.RightBorder].Color = Color.Black;
                    range.ApplyStyle(style, st);


                    
                    // Set column width
                    cell.SetColumnWidth(0, 8);
                    cell.SetColumnWidth(1, 25);


                    // Set header value
                    foreach (var type in ws_type)
                    {
                        cell.SetColumnWidth(cell_id_first_row, 25);
                        cell_id_first_row++;
                        cell.SetColumnWidth(cell_id_first_row, 25);
                        cell_id_first_row++;

                    }


                    ws.Cells["A2"].PutValue("STT");
                    ws.Cells["B2"].PutValue("Ngày");

                    cell.Merge(0, 0, 2, 1);
                    cell.Merge(0, 1, 2, 1);

                    cell_id_first_row = 2;
                    foreach (var type in ws_type)
                    {
                        var cell_name = cell.GetCell(0, cell_id_first_row).Name;
                        ws.Cells[cell_name].PutValue(type.Description);
                        cell.Merge(0, cell_id_first_row, 1, 2);
                        cell_id_first_row += 2;
                    }

                    var cell_name_next = cell.GetCell(1, cell_id_first_row).Name;
                    ws.Cells[cell_name_next].PutValue("Tổng doanh thu");
                    cell.Merge(0, cell_id_first_row, 2, 1);
                    cell_id_first_row++;

                    cell_name_next = cell.GetCell(1, cell_id_first_row).Name;
                    ws.Cells[cell_name_next].PutValue("Tổng hoa hồng");
                    cell.Merge(0, cell_id_first_row, 2, 1);
                    cell_id_first_row++;


                    cell_id_first_row = 2;
                    foreach (var type in ws_type)
                    {
                        var cell_name = cell.GetCell(1, cell_id_first_row).Name;
                        ws.Cells[cell_name].PutValue("Doanh thu");
                        cell_id_first_row++;
                        cell_name = cell.GetCell(1, cell_id_first_row).Name;
                        ws.Cells[cell_name].PutValue("Hoa hồng");
                        cell_id_first_row++;

                    }

                   
                    #endregion

                    #region Body

                    range = cell.CreateRange(2, 0, list_total_report.Count, max_column);
                    style = ws.Cells["A3"].GetStyle();
                    style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.TopBorder].Color = Color.Black;
                    style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.BottomBorder].Color = Color.Black;
                    style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.LeftBorder].Color = Color.Black;
                    style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style.Borders[BorderType.RightBorder].Color = Color.Black;
                    style.VerticalAlignment = TextAlignmentType.Center;
                    range.ApplyStyle(style, st);

                    Style alignCenterStyle = ws.Cells["A3"].GetStyle();
                    alignCenterStyle.HorizontalAlignment = TextAlignmentType.Center;

                    Style alignRightStyle = ws.Cells["A3"].GetStyle();
                    alignCenterStyle.HorizontalAlignment = TextAlignmentType.Right;
                    alignCenterStyle.VerticalAlignment = TextAlignmentType.Center;

                    Style numberStyle = ws.Cells["A3"].GetStyle();
                    numberStyle.Number = 3;
                    numberStyle.HorizontalAlignment = TextAlignmentType.Right;
                    numberStyle.VerticalAlignment = TextAlignmentType.Center;

                    int RowIndex = 2;

                    foreach (var item in list_total_report)
                    {
                        RowIndex++;

                        ws.Cells["A" + RowIndex].PutValue(RowIndex - 2);
                        ws.Cells["A" + RowIndex].SetStyle(alignCenterStyle);

                        ws.Cells["B" + RowIndex].PutValue(item.DateUsed.ToString("dd/MM/yyyy"));
                        ws.Cells["B" + RowIndex].SetStyle(alignCenterStyle);
                        cell_id_first_row = 2;

                        foreach (var type in ws_type)
                        {
                            var item_by_type = item.ServicesList.FirstOrDefault(x => x.ServiceType == type.CodeValue);
                            if(item_by_type!=null && item_by_type.ServiceType > 0)
                            {
                                var cell_name = cell.GetCell(RowIndex - 1, cell_id_first_row).Name;
                                ws.Cells[cell_name].PutValue(item_by_type.Amount.ToString("N0"));
                                cell_id_first_row++;
                                cell_name = cell.GetCell(RowIndex - 1, cell_id_first_row).Name;
                                ws.Cells[cell_name].PutValue(item_by_type.Commission.ToString("N0"));
                                cell_id_first_row++;

                            }
                            else
                            {
                                var cell_name = cell.GetCell(RowIndex - 1, cell_id_first_row).Name;
                                ws.Cells[cell_name].PutValue("0");
                                cell_id_first_row++;
                                cell_name = cell.GetCell(RowIndex - 1, cell_id_first_row).Name;
                                ws.Cells[cell_name].PutValue("0");
                                cell_id_first_row++;

                            }

                        }

                        cell_name_next = cell.GetCell(RowIndex - 1, cell_id_first_row).Name;
                        ws.Cells[cell_name_next].PutValue((item.ServicesList == null ? 0 : item.ServicesList.Sum(x => x.Amount)).ToString("N0"));
                        cell_id_first_row++;

                        cell_name_next = cell.GetCell(RowIndex - 1, cell_id_first_row).Name;
                        ws.Cells[cell_name_next].PutValue((item.ServicesList == null ? 0 : item.ServicesList.Sum(x => x.Commission)).ToString("N0"));
                        cell_id_first_row++;


                    }

                    #endregion


                    wb.Save(full_path);
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("ExportWSExcel - ReportRepository: " + ex);
            }
            return file_path;
        }
        public async Task<List<WSReportTotalViewModel>> GetWSTotalReportFromData(GenericViewModel<WSReportViewModel> model)
        {
            var list_total_report = new List<WSReportTotalViewModel>();

            try
            {
                //-- Convert Data:
                if (model.ListData != null && model.ListData.Count > 0)
                {
                    var list_date = model.ListData.Select(x => x.StartDate.Date).Distinct();
                    DateTime min_date = list_date.OrderBy(x => x).First();
                    DateTime max_date = list_date.OrderByDescending(x => x).First();
                    foreach (var date in list_date)
                    {
                        var date_min_time = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
                        var date_max_time = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
                        var list_by_date = model.ListData.Where(x => x.StartDate <= date_max_time && x.StartDate >= date_min_time);
                        var service_types = list_by_date.Select(x => x.ServiceType).Distinct();
                        var item = new WSReportTotalViewModel()
                        {
                            DateUsed = date,
                            ServicesList = new List<WSReportTotalServiceViewModel>()
                        };
                        foreach (var type in service_types)
                        {
                            if (type == null) continue;
                            var list_by_date_by_service = list_by_date.Where(x => x.ServiceType == type);
                            item.ServicesList.Add(new WSReportTotalServiceViewModel()
                            {
                                Amount = list_by_date_by_service.Sum(x => x.Amount),
                                Commission = list_by_date_by_service.Sum(x => x.Commission != null ? (double)x.Commission : 0),
                                ServiceType = (int)type
                            });
                        }
                        list_total_report.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetTotalReportFromData - ReportRepository: " + ex);
            }
            return list_total_report;
        }
    }
}
