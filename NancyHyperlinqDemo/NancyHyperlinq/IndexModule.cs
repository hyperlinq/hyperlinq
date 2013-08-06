namespace NancyHyperlinq
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters => IndexView.Index();
        }
    }
}