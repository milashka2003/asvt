# MQTT Publisher & Subscriber

Этот проект иллюстрирует применение библиотеки
MQTTnet (https://github.com/dotnet/MQTTnet) для создания MQTT-клиента, который способен:
- Отправлять сообщения на определенные темы.
- Подписываться на темы и обрабатывать сообщения, которые он получает.

В состав проекта входят:
- Публишер (Publisher): отправляет сообщения на MQTT-брокер.
- Подписчик (Subscriber): подписывается на темы и обрабатывает полученные сообщения.
- MQTT-клиент: универсальный класс для работы с подключением, публикацией и подпиской.

## Структура проекта

- **Lab7.Mqtt.Common:** содержит основной класс `Mqtt`, который управляет подключением и взаимодействием с MQTT-брокером.
- **Lab7.Mqtt.Publisher:** приложение для публикации сообщений.
- **Lab7.Mqtt.Subscriber:** приложение для получения сообщений с подписанных тем.


## Как использовать

### Publisher

1. Запустите приложение `Lab7.Mqtt.Publisher`.
2. Введите текст сообщения в консоль.
3. Нажмите Enter, чтобы отправить сообщение.
4. Введите "exit", чтобы завершить выполнение программы.

### Subscriber

1. Запустите приложение `Lab7.Mqtt.Subscriber`.
2. Программа автоматически подпишется на тему, указанную в `appsettings.json`.
3. При получении сообщения выведет данные в консоль (JSON или текст).

## Ключевые особенности

- **TLS/SSL:** Поддержка защищенных соединений с использованием сертификатов.
- **Поддержка JSON:** Автоматическое сериализация/десериализация JSON-сообщений.
- **Обработка форматов:** Возможность работы с текстом, JSON и бинарными данными.

## Пример вывода

### Publisher
```
Enter your messages (type 'exit' to quit):
> Hello, MQTT!
Sent: Hello, MQTT!
```

### Subscriber
```
Received JSON message on topic 'test/topic': {
  "message": "Hello, MQTT!"
}
```
