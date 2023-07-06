using MediatR;
using Microservices.Produtos.Application.Services.Commands;
using Microservices.Produtos.Application.Services.Queries;
using Microservices.Produtos.CrossCutting;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Microservices.Produtos.API
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
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddInfrastructure(Configuration);

            services.AddMediatR(typeof(CreateProdutoCommand).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(DeleteProdutoByIdCommand).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(UpdateProdutoCommand).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetAllProdutosQuery).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetProdutoByIdQuery).GetTypeInfo().Assembly);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Microservices.Produtos.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Microservices.Produtos.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
