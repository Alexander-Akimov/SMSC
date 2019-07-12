# SMSC
 Класс клиента - SmscClient из проекта SMSC.Client
 Для отправи сообщений на сервер использован класс HttpClient.
 
 Cервер реализован на Asp.Net Core Web API. 
 Работает по адресу https://localhost:5001.
 Запросы обрабатываются контроллером ServerController в методе SendMessages().
  
 Взаимодействие между клиентом и сервером происходит по HTTPS протоколу.
 Сообщения отправляются в виде XML в теле запроса\ответа.
 
 Для сериализации/десериализации используется класс XmlSerializer
 (services.AddMvc().AddXmlSerializerFormatters() - на сервере;
 new XmlMediaTypeFormatter { UseXmlSerializer = true }) - на клиенте)
 
 Запрос содержит сериализованный в XML объект класса PackageRequest.
 Ответ - сериализованный в XML экземпляр PackageResponse.
 Фатальная ошибка - сериализованный в XML экземпляр ErrorResponse.
 
 
 
1) Запустить сервер SMSC.Server.
2) Консольное приложение TestClientConsoleApp отправляет тестовое сообщение на сервер и получает ответ от него.
Все ошибки выводятся в консольное окно приложения.
