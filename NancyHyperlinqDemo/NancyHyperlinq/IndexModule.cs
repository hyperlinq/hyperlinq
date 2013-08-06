namespace NancyHyperlinq
{
    using Nancy;
    using Nancy.ModelBinding;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            var presenter = new MainView();

            Get["/"]                     = p => presenter.Index ();
            Get["/about"]                = p => presenter.About ();
            Get["/exampleForm"]          = p => presenter.ExampleForm ();
            Post["/postExampleForm/"]    = p => presenter.PostExampleForm(this.Bind<ZooModel>());
        }
    }
}