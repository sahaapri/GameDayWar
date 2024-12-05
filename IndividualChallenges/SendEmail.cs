public void SendEmail(string recipient, string message)
{
    var smtp = new SmtpClient("smtp.example.com", 587) // Secure: Using port 587 for TLS
    {
        Credentials = new NetworkCredential("user@example.com", "password"),
        EnableSsl = true // Enable secure communication
    };
    smtp.Send("user@example.com", recipient, "Subject", message);
    Console.WriteLine("Email sent to: " + recipient);
}
