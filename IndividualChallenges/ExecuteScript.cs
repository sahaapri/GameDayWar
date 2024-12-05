public void ExecuteScript(string userInput)
{
    // Hypothetical scripting engine
    string script = $"eval({userInput})";
    dynamic engine = Activator.CreateInstance(Type.GetType("HypotheticalScriptingEngine"));
    engine.Execute(script);
}
