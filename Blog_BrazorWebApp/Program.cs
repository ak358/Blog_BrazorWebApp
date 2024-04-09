using Blog_BrazorWebApp.Components;
using Blog_BrazorWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;

namespace Blog_BrazorWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents() // Razorコンポーネントを追加
                .AddInteractiveServerComponents(); // インタラクティブサーバーコンポーネントを追加

            builder.Services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection")); // データベースコンテキストを追加し、SQL Serverを使用するように構成

            builder.Services.AddQuickGridEntityFrameworkAdapter(); // QuickGrid Entity Framework アダプターを追加

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme) // 認証サービスを追加し、Cookie認証を設定
                .AddCookie(options => {
                    options.Cookie.Name = "auth_token"; // Cookie名を設定
                    options.LoginPath = "/login"; // ログインページのパスを設定
                    options.Cookie.MaxAge = TimeSpan.FromMinutes(30); // Cookieの有効期限を設定
                    options.AccessDeniedPath = "/access-denied"; // アクセス拒否ページのパスを設定
                });
            builder.Services.AddAuthorization(); // 認可サービスを追加
                                                 // Blazor用の認証情報を提供するためのコンポーネント
            builder.Services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
            builder.Services.AddCascadingAuthenticationState(); // カスケーディング認証状態を追加


            var app = builder.Build(); // アプリケーションを構築

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error"); // 例外処理ミドルウェアを使用してエラーページにリダイレクト
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts(); // HSTSを使用してセキュリティを向上させる。本番環境では値の調整が必要
            }

            app.UseHttpsRedirection(); // HTTPSへのリダイレクトを有効化

            app.UseStaticFiles(); // 静的ファイルの提供を有効化
            app.UseAntiforgery(); // CSRF対策のためのAntiforgeryミドルウェアを有効化

            app.UseAuthentication(); // 認証ミドルウェアを有効化
            app.UseAuthorization(); // 認可ミドルウェアを有効化

            app.MapRazorComponents<App>() // Razorコンポーネントのマッピングを設定
                .AddInteractiveServerRenderMode(); // インタラクティブサーバーレンダリングモードを追加


            app.Run(); // アプリケーションを実行
        }
    }
}
