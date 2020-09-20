using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// models the users of the system
/// </summary>
namespace BlazorClient.Shared
{
    public class SystemUsers
    {
        public string id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public List<string> roles { get; set; } = new List<string>();
    }
}
