using System.Web.Http;
using WebActivatorEx;
using CICDDemo;
using Swashbuckle.MVC.Handler;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
[assembly: PreApplicationStartMethod(typeof(SwaggerMVCConfig), "Register")]
namespace CICDDemo
{
    public class SwaggerMVCConfig
    {
		public static void Register()
        {
			DynamicModuleUtility.RegisterModule(typeof(SwashbuckleMVCModule));
		}
	}
}