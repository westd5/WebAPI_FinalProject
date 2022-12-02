using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebAPI_FinalProject.Data;
using WebAPI_FinalProject.Interfaces;

namespace WebAPI_FinalProject
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
            services.AddControllers();

            services.AddSwaggerDocument(settings => { settings.Title = "Contemporary Programming: Web API Final Project"; });

            services.AddDbContext<WebAPI_FinalProjectContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebAPI_FinalProjectContext")));
            services.AddScoped<ITeamMemberContextDAO, TeamMemberContextDAO>();
            services.AddScoped<ITalkingHeadsAlbumContextDAO, TalkingHeadsAlbumContextDAO>();
            services.AddScoped<IPortfolioProjectContextDAO, PortfolioProjectContextDAO>();
            services.AddScoped<IStarTrekVoyagerEpisodeContextDAO, StarTrekVoyagerEpisodeContextDAO>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, WebAPI_FinalProjectContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            context.Database.Migrate();
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
