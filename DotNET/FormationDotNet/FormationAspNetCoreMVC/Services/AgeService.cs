namespace FormationAspNetCoreMVC.Services
{
    public class AgeService
    {
        private ToolsService _toolsService;

        public AgeService(ToolsService toolsService)
        {
            _toolsService = toolsService;
        }
        public string Convert(int age)
        {
            return _toolsService.AlterString(age.ToString());
        }
    }
}
