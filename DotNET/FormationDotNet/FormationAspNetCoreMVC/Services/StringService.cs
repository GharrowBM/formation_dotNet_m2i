namespace FormationAspNetCoreMVC.Services
{
    public class StringService : IStringService
    {
        private ToolsService _toolsService;
        public StringService(ToolsService toolsService)
        {
            _toolsService = toolsService;
        }
        public string Convert(string s)
        {
            string result = null;
            if (s.Length % 2 == 0)
            {
                result = s.ToLower();
            }
            else
            {
                result = s.ToUpper();
            }
            return _toolsService.AlterString(result);
        }
    }
}
