using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GraderaPublic.Startup))]
namespace GraderaPublic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
