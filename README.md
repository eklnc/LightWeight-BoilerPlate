# LightWeight-BoilerPlate

Deneme yapabilmek için;

* MicRosoft Visual Studio'dan Server Explorer açılıp kendi local db'nizi eklemeniz ve
* LWBoilerPlate.Models'deki app.Config'te ve LWBoilerPlate'deki web.Config'te bulunan connectionString'i bağladığınız local db'nin connectionString'i ile değiştirmeniz 

gerekmektedir.

###### **DB için gerekli sql dosyalarını SQL Scripts klasörü içerisinde bulabilirsiniz.**

Proje içerisinde debug yapmak isterseniz aşağıdaki iki yeri öneririm:
* Global.asax içerisindeki Application_Start'a breakpoint koyarak ya da 
* HomeController içerisindeki Index metoduna breakpoint koyarak