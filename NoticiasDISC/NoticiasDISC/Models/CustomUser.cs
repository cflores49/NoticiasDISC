using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace NoticiasDISC.Models
{
    public class CustomUser : IUser<string>
    {
        public string Id { get; set; }

        public string UserName { get; set; }
    }
}
