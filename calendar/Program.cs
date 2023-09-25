using calendar.ENTİTİES;

Console.WriteLine("Calendar app");
Meeting meeting1 = new()
{ Id = Guid.NewGuid(),
    Title = "Ders Seçimi",
    Details = new List<string> { "seçtiğin dersleri belirtilen sürede seçmelisin,onayladığından emin olup siteden çıkış yap" },
    StartTime = new DateTime(2023, 09, 25, 09, 00, 00),

    EndTime = new DateTime(2023, 09, 25, 09, 10, 00),
    
    Guests = new() { "sudeopann@gmail.com","tugbakeyik@gmail.com"},
};
 Todo  todo1 = new()
 {
     Id = Guid.NewGuid(),
     Title = "katılımcı bilgilerini teslim et",
     Details = new List<string>{ "dersini seçemediğin için 13.30 da tekrar seçim yap" },
    StartTime = new DateTime(2023, 09, 25, 09, 00, 00),

    EndTime = new DateTime(2023, 09, 25, 09, 10, 00),
    Importance="high Priority"
};


meeting1.GetNotification();
todo1.GetNotification();
  
