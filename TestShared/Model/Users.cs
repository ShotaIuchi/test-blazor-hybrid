using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestShared.Model
{
    public class Users
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Phone { get; set; } = "";
        [JsonProperty("Email")]
        [Column("Email")]
        public string Mail { get; set; } = "";
        public int BaseId { get; set; } = 0;
        public Base? Base { get; set; } = null;
        public int StatusId { get; set; } = 0;
        public Status? Status { get; set; } = null;
    }
}
