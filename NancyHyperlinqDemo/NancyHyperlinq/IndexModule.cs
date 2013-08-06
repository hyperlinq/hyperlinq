namespace NancyHyperlinq
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            var presenter = new MainPresenter();

            Get["/"] = parameters => presenter.Index();
            Get["/about"] = parameters => presenter.About();
        }
    }
}