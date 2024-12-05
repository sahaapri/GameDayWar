public void ExecuteScript(string userInput)
{
    // Hypothetical scripting engine
    string safeInput = HttpUtility.HtmlEncode(userInput); 
    dynamic engine = Activator.CreateInstance(Type.GetType("HypotheticalScriptingEngine"));
    engine.Execute(script);
}
