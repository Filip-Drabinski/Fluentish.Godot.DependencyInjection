[assembly: Fluentish.InjectableStatic.InjectableStaticConfiguration(
    Namespace = "Fluentish.Godot.DependencyInjection.Services",
    NamespaceMode = Fluentish.InjectableStatic.NamespaceMode.Const
)]

[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.GD))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.Input))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.Engine))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.Performance))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.OS))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.ProjectSettings))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.ResourceLoader))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.ResourceSaver))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.FileAccess))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.InputMap))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.MultiplayerApi))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.TranslationServer))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.Mathf))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.PhysicsServer2D))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.PhysicsServer3D))]
[assembly: Fluentish.InjectableStatic.Injectable(typeof(Godot.RenderingServer))]