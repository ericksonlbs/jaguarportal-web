namespace WebJaguarPortal.ViewModels
{
    public class AnalyzeGridItemViewModel
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string Version { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class AnalyzeDetailViewModel
    {
        public IEnumerable<FileManagerItemViewModel>? FilesAndPaths { get; set; }
        public IEnumerable<LineAnalysisViewModel>? Susp { get; set; }        
    }
}
