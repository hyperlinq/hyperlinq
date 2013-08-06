namespace NancyHyperlinq
{
    using Nancy;
    using Nancy.ModelBinding;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            var view = new MainView();

            Get["/"]                     = p => view.Index ();
            Get["/about"]                = p => view.About ();
            Get["/exampleForm"]          = p => view.ExampleForm ();
            Post["/postExampleForm/"]    = p => view.PostExampleForm(this.Bind<ZooModel>());
        }
    }
}