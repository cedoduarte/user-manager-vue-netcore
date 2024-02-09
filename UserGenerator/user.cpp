#include "user.h"

#include <QDebug>

void User::print() const
{
    qDebug().noquote().nospace() << ",";
    qDebug().noquote().nospace() << "new User()";
    qDebug().noquote().nospace() << "{";
    qDebug().noquote().nospace() << "\tFirstName = \"" << firstName << "\",";
    qDebug().noquote().nospace() << "\tLastName = \"" << lastName << "\",";
    qDebug().noquote().nospace() << "\tCountry = \"" << country << "\",";
    qDebug().noquote().nospace() << "\tProvince = \"" << province << "\",";
    qDebug().noquote().nospace() << "\tCity = \"" << city << "\",";
    qDebug().noquote().nospace() << "\tZipCode = \"" << zipCode << "\",";
    qDebug().noquote().nospace() << "\tBirthdate = " << birthdate << ",";
    qDebug().noquote().nospace() << "\tPhoneNumber = \"" << phoneNumber << "\",";
    qDebug().noquote().nospace() << "\tEmail = \"" << email << "\",";
    qDebug().noquote().nospace() << "\tUsername = \"" << username << "\",";
    qDebug().noquote().nospace() << "\tPasswordHash = " << passwordHash << ",";
    qDebug().noquote().nospace() << "\tLinkedInProfileUrl = \"" << linkedInProfileUrl << "\"";
    qDebug().noquote().nospace() << "}";
}
