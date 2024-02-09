#include "mainwindow.h"
#include "./ui_mainwindow.h"
#include "user.h"

#include <QRandomGenerator>
#include <QDebug>

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    m_firstNameList = {
        "Carlos",
        "Juan",
        "Luis",
        "Manuel",
        "Javier",
        "Leonel",
        "Eliazar",
        "Joaquin",
        "Jhonatan",
        "Gabriel",
        "Fabrizio",
        "Rafaél",
        "Miguel",
        "Fernando",
        "Nicolás",
        "José",
        "Arturo",
        "Aarón",
        "Moisés",
        "Alejandro",
        "Alexander",
        "Óscar",
        "Daniel",
        "Federico",
        "Christian",
        "Estéban",
        "Sebastián",
        "Felipe",
        "Gerardo",
        "Amadeus",
        "António",
        "Fitzgerald",
        "Ángel"
    };
    m_lastNameList = {
        "Miranda",
        "Juárez",
        "López",
        "Martínez",
        "Aguirre",
        "León",
        "Enríquez",
        "Conriquez",
        "Rodríguez",
        "Domínguez",
        "Ramones",
        "Zavala",
        "Castrejón",
        "Pérez",
        "Prado",
        "Trujillo",
        "Álvarez",
        "Nevárez",
        "Gómez",
        "Gámez",
        "González",
        "Gonzalí",
        "Contreras",
        "Carrillo",
        "Fernández",
        "Bustamante",
        "Claro",
        "Jiménez",
        "Quintero",
        "Árce",
        "Higareda",
        "Higuera",
        "Lastra"
    };

    for (int i = 0; i < 1000; i++)
    {
        int firstName1 = QRandomGenerator::global()->bounded(0, int(m_firstNameList.size()));
        int firstName2 = QRandomGenerator::global()->bounded(0, int(m_firstNameList.size()));

        int lastName1 = QRandomGenerator::global()->bounded(0, int(m_lastNameList.size()));
        int lastName2 = QRandomGenerator::global()->bounded(0, int(m_lastNameList.size()));

        QString firstName = QString("%1 %2").arg(m_firstNameList[firstName1], m_firstNameList[firstName2]);
        QString lastName = QString("%1 %2").arg(m_lastNameList[lastName1], m_lastNameList[lastName2]);


        int year = QRandomGenerator::global()->bounded(1950, 2005);
        int month = QRandomGenerator::global()->bounded(1, 13);
        int day = QRandomGenerator::global()->bounded(1, 28);
        QString birthdate = QString("new DateTime(%1, %2, %3)").arg(year).arg(month).arg(day);

        QString phoneNumber = QString("+52%1%2%3%4%5%6%7%8%9%10")
            .arg(QRandomGenerator::global()->bounded(0, 10))
            .arg(QRandomGenerator::global()->bounded(0, 10))
            .arg(QRandomGenerator::global()->bounded(0, 10))
            .arg(QRandomGenerator::global()->bounded(0, 10))
            .arg(QRandomGenerator::global()->bounded(0, 10))
            .arg(QRandomGenerator::global()->bounded(0, 10))
            .arg(QRandomGenerator::global()->bounded(0, 10))
            .arg(QRandomGenerator::global()->bounded(0, 10))
            .arg(QRandomGenerator::global()->bounded(0, 10))
            .arg(QRandomGenerator::global()->bounded(0, 10));

        QString email = QString("%1%2%3@hotmail.com")
            .arg(firstName.toLower())
            .arg(lastName.toLower())
            .arg(QRandomGenerator::global()->bounded(0, 1000));
        email = email.replace(" ", "");
        replaceAccentedLetters(email);

        QString username = QString("%1%2").arg(firstName.toLower()).arg(QRandomGenerator::global()->bounded(0, 1000));
        username = username.replace(" ", "");
        replaceAccentedLetters(username);

        QString passwordHash = QString("Util.GetSha256(\"%1\")").arg("Um8$qfjp");

        QString linkedInProfileUrl = QString("https://www.linkedin.com/in/%1%2").arg(firstName.toLower(), lastName.toLower());
        linkedInProfileUrl = linkedInProfileUrl.replace(" ", "");
        replaceAccentedLetters(linkedInProfileUrl);

        User newUser {
            firstName,
            lastName,
            "México",
            "Sonora",
            "Hermosillo",
            "83170",
            birthdate,
            phoneNumber,
            email,
            username,
            passwordHash,
            linkedInProfileUrl
        };

        newUser.print();
    }
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::replaceAccentedLetters(QString &input) const
{
    input = input.replace("á", "a")
                 .replace("é", "e")
                 .replace("í", "i")
                 .replace("ó", "o")
                 .replace("ú", "u");
}
