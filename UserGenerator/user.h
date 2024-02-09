#ifndef USER_H
#define USER_H

#include <QString>

struct User
{
    QString firstName;
    QString lastName;
    QString country;
    QString province;
    QString city;
    QString zipCode;
    QString birthdate;
    QString phoneNumber;
    QString email;
    QString username;
    QString passwordHash;
    QString linkedInProfileUrl;

    void print() const;
};

#endif // USER_H
