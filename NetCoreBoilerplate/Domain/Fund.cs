namespace Domain
{
    public class Fund
    {
        public string ISIN { get; set; }
        public string Currency { get; set; }
        public string Name { get; set; }
        public string Management { get; set; }
        public string Focus { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }


        public string PerformanceYTD { get; set; }
        public string Performance1Year { get; set; }
        public string Performance3Year { get; set; }
        public string Performance5Year { get; set; }
        public string PerformanceFromBeggining { get; set; }
        public string PerformanceAverage { get; set; }


        public string Performances { get; set; }
        public string Years { get; set; }
        public string Volatilities { get; set; }
        public string SharpRates { get; set; }
        public string BestMonths { get; set; }
        public string WorstMonths { get; set; }
        public string MaxLosses { get; set; }
        public string OverFulFilments { get; set; }
        public string MonthlyPerformances { get; set; }

    }
}
