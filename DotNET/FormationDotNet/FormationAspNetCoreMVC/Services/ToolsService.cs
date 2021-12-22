using System;

namespace FormationAspNetCoreMVC.Services
{
    public class ToolsService
    {
        private string hash = Guid.NewGuid().ToString();
        public string AlterString(string s)
        {
            return s+"-"+hash;
        }
    }
}
