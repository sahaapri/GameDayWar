public void EmbedUserInputInScript(string userInput)
{
    // Insecure: Embeds user input directly into a <script> tag
    var html = $"<script>alert('{userInput}')</script>";
    Console.WriteLine("Generated HTML: " + html);
}
