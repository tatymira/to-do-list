using System.Web.Http;
using WebActivatorEx;
using ToDoList;
using Swashbuckle.Application;
using System;
using System.Linq;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace ToDoList
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Swagger");

                    c.IgnoreObsoleteActions();
                    c.IncludeXmlComments($@"{AppDomain.CurrentDomain.BaseDirectory}\bin\Swagger.xml");
                    c.IgnoreObsoleteProperties();

                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                })
                .EnableSwaggerUi(c =>
                {
                    c.DocumentTitle("Exemplo de utilização do Swagger");
                    c.DocExpansion(DocExpansion.List);
                });
        }
    }
}
