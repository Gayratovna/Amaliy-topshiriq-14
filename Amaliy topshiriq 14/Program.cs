using Amaliy_topshiriq_14;


    BinarDaraxt telefonDaraxti = new BinarDaraxt(new Telefon("123", "John Doe", "12:00"));
    telefonDaraxti.MalumotKiritish(new Telefon("456", "Alice Smith", "14:30"));
        telefonDaraxti.MalumotKiritish(new Telefon("789", "Bob Johnson", "16:45"));

        // 1. Barcha ma’lumotlarni chiqarish
        Console.WriteLine("Barcha Ma'lumotlar:");
    telefonDaraxti.BarchaMalumotlarniChiqarish();
        Console.WriteLine();

    // 2. Telefon raqami va so’zlashuv vaqtini chiqarish
    Console.WriteLine("Telefon Raqami va So’zlashuv Vaqti:");
    telefonDaraxti.TelefonRaqaminiChiqarish("456");
