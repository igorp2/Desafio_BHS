using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPedidos.Data;
using SmartPedidos.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SmartPedidos
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
                    
            //Lendo do arquivo...
            int count = 0;  
            string linha;  
            List<String> linhas = new List<String>();

            System.IO.StreamReader file = new System.IO.StreamReader("Data/Desafio.txt");  
            while((linha = file.ReadLine()) != null)  
            {  
                linhas.Add(linha);
                count++; 
            }
            file.Close(); 

            //Verificando se o banco está vazio...
            System.Data.SqlClient.SqlConnection sqlConnection1 = 
            new System.Data.SqlClient.SqlConnection(Configuration.GetConnectionString("DefaultConnection"));
            
            System.Data.SqlClient.SqlCommand cmd2 = new System.Data.SqlClient.SqlCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT COUNT(*) FROM Pedidos";
            cmd2.Connection = sqlConnection1;       
            sqlConnection1.Open();
            cmd2.ExecuteNonQuery();
            var qtd_linhas = (int)cmd2.ExecuteScalar();
            sqlConnection1.Close();  

            //Inserindo no banco os dados do arquivo...
            int i = 0;  
            if(qtd_linhas == 0){
                while(i != count){

                    int tamanho;
                    int tipo;
                    int Codigo;
                    int CodigoPedido;
                    string Descricao;
                    string Hora;
                    double Valor;
                    double ValorItem;
                    string Status;

                    tamanho = linhas[i].Length;
                    //Console.WriteLine(linhas[i]);
                    tipo = Convert.ToInt32(linhas[i].Substring(0,1));
                    //Console.WriteLine(tipo);

                    if(tipo == 1){
                        Codigo = Convert.ToInt32(linhas[i].Substring(1,5));
                        //Console.WriteLine(codigo);
                        if(tamanho == 74){
                            Descricao = linhas[i].Substring(6,43);
                            //Console.WriteLine(descricao);
                            Hora = linhas[i].Substring(49,14);
                            //Console.WriteLine(hora);
                            Valor = Convert.ToDouble(linhas[i].Substring(63,10));
                            //Console.WriteLine(valor);
                            Status = linhas[i].Substring(73,1);
                            //Console.WriteLine(status);

                        }
                        else{
                            Descricao = linhas[i].Substring(6,42);
                            //Console.WriteLine(descricao);
                            Hora = linhas[i].Substring(48,14);
                            //Console.WriteLine(hora);
                            Valor = Convert.ToDouble(linhas[i].Substring(62,10)); 
                            //Console.WriteLine(valor);
                            Status = linhas[i].Substring(72,1);
                            //Console.WriteLine(status);
                        }

                        System.Data.SqlClient.SqlCommand cmdd = new System.Data.SqlClient.SqlCommand();
                            cmdd.CommandType = System.Data.CommandType.Text;

                            var ano = Convert.ToInt32(Hora.Substring(0, 4));
                            var mes = Convert.ToInt32(Hora.Substring(4, 2));
                            var dia = Convert.ToInt32(Hora.Substring(6, 2));
                            var hora = Convert.ToInt32(Hora.Substring(8, 2));
                            var minuto = Convert.ToInt32(Hora.Substring(10, 2));
                            var segundo = Convert.ToInt32(Hora.Substring(12, 2));

                            var dataConvertida = new DateTime(ano, mes, dia, hora, minuto, segundo);
                            
                            
                            cmdd.CommandText = "INSERT Pedidos (Descricao, DataPedido, ValorPedido, Status) VALUES ('" + Descricao + "', '" + dataConvertida.ToString("yyyy-MM-dd HH:mm:ss") + "', " + Valor.ToString("r") + ", '" + Status + "')";
                            //cmdd.CommandText = "INSERT Pedidos (Descricao, DataPedido, ValorPedido, Status) VALUES ('Legal', '" + dataConvertida.ToString() + "', 300, 'E')";
                            
                            cmdd.Connection = sqlConnection1;

                            sqlConnection1.Open();
                            cmdd.ExecuteNonQuery();
                            sqlConnection1.Close();
                    }
                    else{
                        Codigo = Convert.ToInt32(linhas[i].Substring(1,5));
                        //Console.WriteLine(codigo);
                        CodigoPedido = Convert.ToInt32(linhas[i].Substring(6,5));
                        //Console.WriteLine(codigopedido);
                        Descricao = linhas[i].Substring(11,40);
                        //Console.WriteLine(descricao);
                        ValorItem = Convert.ToDouble(linhas[i].Substring(44,10)); 
                        //Console.WriteLine(valoritem);
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "INSERT Itens (CodigoPedido, Descricao, ValorItem) VALUES ('" + Convert.ToString(CodigoPedido) + "','"  + Descricao + "'," + ValorItem.ToString("r") + ")";
                        cmd.Connection = sqlConnection1;

                        sqlConnection1.Open();
                        cmd.ExecuteNonQuery();
                        sqlConnection1.Close();
                    }
                    i++;
                }
            }
                 

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
