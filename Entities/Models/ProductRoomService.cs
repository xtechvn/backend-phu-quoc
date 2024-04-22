using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ProductRoomService
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public string ContractNo { get; set; }
        public string PackageId { get; set; }
        public string ProviderId { get; set; }
        public string RoomId { get; set; }
        public int? GroupProviderType { get; set; }
        public string AllotmentsId { get; set; }

        public virtual Campaign Campaign { get; set; }
    }
}
