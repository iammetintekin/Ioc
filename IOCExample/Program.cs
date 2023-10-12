using IOCExample;
using Ninject;

// IOC frameworks
// ninject,unity, castle windsor, structure map
// dry ioc, light inject
// katmanlar arası geçişlerde kullanılabilir, fakat 2 manager birbirini kullanıyorsa tercih etmeyiz.

var kernel = new StandardKernel();
// bu kullanım .net core config dosyalarında farklıdır.
kernel.Bind<IMevzuat>().To<FirstMevzuat>().InSingletonScope();


//Transient: Obje her istenildiğinde yeni bir instance oluşturularak verilir.
//Scoped: Yeni bir istek geldiğinde yeni bir obje oluşturulur.
//Singleton: İlk istek geldiğinde bir tane instance oluşturulur, sonrasında gelen tüm isteklerde her zaman aynı instance verilir.
// kerneldan bir IMevzuat istedik yukarıda ise hangisinin gönderilmesi gerektiğini belirttik.


CustomerManager manager = new CustomerManager(kernel.Get<IMevzuat>());
await manager.Add();

//IoC kullanmanın avantajlarını şöyle sıralayabiliriz:
//bağımlılığı az sınıflar oluşturma
//Kolay unit test yazma
//Yönetilebilirlik
//Modüler programlar
//Farklı implementasyonlar arası kolay geçiş