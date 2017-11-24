using Raven.Client.Documents;
using System;

namespace RedSteakServer.Models.Singletons
{
    public class DocumentStoreHolder
    {
        private static Lazy<IDocumentStore> store = new Lazy<IDocumentStore>(CreateStore);

        public static IDocumentStore Store
        {
            get { return store.Value; }
        }

        private static IDocumentStore CreateStore()
        {
            IDocumentStore store = new DocumentStore() {
                Urls = new [] { "http://localhost:1234" },
                Database = "RedSteak"
            };

            store.Initialize(); // initializes document store, by connecting to server and downloading various configurations

            return store;
        }
    }
}