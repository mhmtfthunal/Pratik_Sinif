# Pratik Sınıf Uygulaması

Bu uygulama, C# dilinde basit bir **nesne yönelimli programlama (OOP)** örneği olarak geliştirilmiştir. Projede kalıtım (inheritance) yapısı kullanılarak `Teacher` ve `Student` sınıfları, ortak özellikleri içeren `Person` sınıfından türetilmiştir.

## 📁 Proje Yapısı

```
Pratik_Sinif/
|
|├— Models/
|   ├— Person.cs     → Ortak özelliklerin bulunduğu temel sınıf
|   ├— Teacher.cs    → Öğretmen nesnesi, Person'dan kalıtılır
|   └— Student.cs    → Öğrenci nesnesi, Person'dan kalıtılır
|
└— Program.cs        → Uygulamanın giriş noktası (Main metodu)
```

## 👨‍🏫 Kullanılan Sınıflar

### Person.cs

Tüm kişiler için ortak olan özellikleri içerir:

```csharp
public string Name { get; set; }
public string SurName { get; set; }
public int BirthDay { get; set; }
```

### Teacher.cs

`Person` sınıfından türetilmiştir. Öğretmen nesneleri için kullanılır.

### Student.cs

`Person` sınıfından türetilmiştir. Öğrenci nesneleri için kullanılır.

## ▶️ Program Akışı

Program.cs dosyasında bir öğretmen ve bir öğrenci nesnesi oluşturulup, bilgiler konsola yazdırılır:

```csharp
Teacher teacher = new Teacher()
{
    Name = "Sinan",
    SurName = "Ferza",
    BirthDay = 1981
};

Student student = new Student()
{
    Name = "Selim",
    SurName = "Bezgin",
    BirthDay = 1998
};
```

Ardından şu çıktılar alınır:

```
Öğretmenimiz Sinan derslerinde başarılı örnekler kullanmaktadır.
Öğrencilerimizden de Selim 1998 yılında doğduğunu anlattı.
```

## 💡 Amaç

Bu örnekle birlikte:

* Kalıtım (inheritance) mantığı,
* Nesne oluşturma ve özellik atama,
* Konsola çıktı verme

gibi temel OOP kavramları öğrenilmiş olur.

## 📌 Not

Tüm sınıflar `internal` tanımlandığı için sadece aynı proje içerisinde erişilebilir durumdadır. Daha geniş kapsamda kullanılacaksa `public` olarak değiştirilmesi gerekir.
