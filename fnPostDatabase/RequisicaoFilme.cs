namespace fnPostDatabase
{
    internal class RequisicaoFilme
    {
        public string id { get { return Guid.NewGuid().ToString(); } }
        public string titulo { get; set; }
        public string ano { get; set; }
        public  string video { get; set; }
        public string detalhes { get; set; }
    }
}
