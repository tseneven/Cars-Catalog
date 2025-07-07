# Описание
Небольшой Pet-проект на C#, затрагивающий основные аспекты junior-разработки на .NET: работа с базой данных, API, авторизация, валидация, тесты и пользовательский интерфейс.

# Стек технологий
.NET / C#

ASP.NET Core Web API

Windows Forms

MSSQL

ADO.NET

xUnit / NUnit

JSON / HttpClient

# Структура
```
Cars-Catalog
│
├── API               # ASP.NET Core API (контроллеры, репозитории, логика)
├── Classes           # Модели данных (DTO, Entity и т.д.)
├── WindowsForms      # WinForms клиент для работы с каталогом машин
├── Tests             # Модульные/интеграционные тесты
├── README.md         # Это описание проекта
```

# Функционал
Регистрация и авторизация пользователя

Валидация данных на уровне API и UI

Отправка и получение JSON

Каталог автомобилей (CRUD-операции)

Тесты для проверки логики

Интерфейс на WinForms для взаимодействия с пользователем

# Запуск
Клонировать репозиторий:
```
git clone https://github.com/tseneven/Cars-Catalog.git
cd Cars-Catalog
```
Обновить строку подключения в appsettings.json

Запустить API:

В Visual Studio — запустить проект API.

Запустить WinForms клиент:

Открыть WindowsForms проект, запустить с UI.

Возможна реализация запуск через exe

Автор: [tseneven](https://github.com/tseneven)

