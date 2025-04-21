using Godot.DependencyInjection.Services.Logger;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddGodotServices(this IServiceCollection services)
        {
            services.AddGodotLogger();

            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IGD, Fluentish.Godot.DependencyInjection.Services.GDService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IInput, Fluentish.Godot.DependencyInjection.Services.InputService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IEngine, Fluentish.Godot.DependencyInjection.Services.EngineService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IPerformance, Fluentish.Godot.DependencyInjection.Services.PerformanceService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IOS, Fluentish.Godot.DependencyInjection.Services.OSService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IProjectSettings, Fluentish.Godot.DependencyInjection.Services.ProjectSettingsService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IResourceLoader, Fluentish.Godot.DependencyInjection.Services.ResourceLoaderService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IResourceSaver, Fluentish.Godot.DependencyInjection.Services.ResourceSaverService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IFileAccess, Fluentish.Godot.DependencyInjection.Services.FileAccessService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IInputMap, Fluentish.Godot.DependencyInjection.Services.InputMapService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IMultiplayerApi, Fluentish.Godot.DependencyInjection.Services.MultiplayerApiService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.ITranslationServer, Fluentish.Godot.DependencyInjection.Services.TranslationServerService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IMathf, Fluentish.Godot.DependencyInjection.Services.MathfService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IPhysicsServer2D, Fluentish.Godot.DependencyInjection.Services.PhysicsServer2DService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IPhysicsServer3D, Fluentish.Godot.DependencyInjection.Services.PhysicsServer3DService>();
            services.AddSingleton<Fluentish.Godot.DependencyInjection.Services.IRenderingServer, Fluentish.Godot.DependencyInjection.Services.RenderingServerService>();
            return services;
        }

        public static IServiceCollection AddGodotLogger(this IServiceCollection services, Action<ILoggingBuilder>? configure = null)
        {
            services.AddLogging(x =>
            {
                x.AddGodot();
                configure?.Invoke(x);
            });
            return services;
        }

    }
}
