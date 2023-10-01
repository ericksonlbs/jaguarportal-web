namespace WebJaguarPortal.Areas.Api.Models
{
    public class AnalysisControlFlowModel
    {
        public string ProjectKey { get; set; }
        public int TestsFail { get; set; }
        public int TestsPass { get; set; }
    }
}
