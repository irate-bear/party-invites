using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static List<GuestResponse> Responses => responses;
        public static void AddResponse(GuestResponse response)
        {
            Responses.Add(response);
        }
        
    }
}