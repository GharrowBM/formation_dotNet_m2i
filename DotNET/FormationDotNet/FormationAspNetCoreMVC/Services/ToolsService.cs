using System;

namespace FormationAspNetCoreMVC.Services
{
    public class ToolsService
    {
        public string AlterString(string s)
        {
            return s+"-"+Guid.NewGuid().ToString();
        }
    }
}
