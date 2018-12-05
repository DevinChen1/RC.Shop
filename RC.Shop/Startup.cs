using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog.Web;
using RC.Shop.Data;
using Senparc.CO2NET.RegisterServices;
using Senparc.Weixin;
using Senparc.Weixin.MP.Containers;
using Senparc.Weixin.RegisterServices;

namespace RC.Shop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShopDBContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.Configure<CookiePolicyOptions>(options =>

            {

                // This lambda determines whether user consent for non-essential cookies is needed for a given request.

                options.CheckConsentNeeded = context => false;//这里要改为false，默认是true，true的时候session无效

                options.MinimumSameSitePolicy = SameSiteMode.None;

            });

            //Session 保存到内存

            services.AddDistributedMemoryCache();

            services.AddSession();
            //services.AddSingleton(typeof(DbContext), typeof(ShopDBContext));



            //services.AddSenparcGlobalServices(Configuration)//Senparc.CO2NET 全局注册

            //       .AddSenparcWeixinServices(Configuration);//Senparc.Weixin 注册


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            loggerFactory.AddNLog();
            env.ConfigureNLog("nlog.config");

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            }); 
            //// 启动 CO2NET 全局注册，必须！

            //IRegisterService register = RegisterService.Start(env, senparcSetting.Value)

            //                                            .UseSenparcGlobal(false, null);



            ////开始注册微信信息，必须！

            //register.UseSenparcWeixin(senparcWeixinSetting.Value, senparcSetting.Value);

            ////除此以外，仍然可以在程序任意地方注册公众号或小程序：

            //AccessTokenContainer.Register(WeiXinConfig.appId, WeiXinConfig.AppSecret, "工厂联盟");//命名空间：Senparc.Weixin.MP.Containers


        }
    }
}
