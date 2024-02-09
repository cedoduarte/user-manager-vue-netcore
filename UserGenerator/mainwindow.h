#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <vector>

namespace Ui
{
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT
public:
    MainWindow(QWidget *parent = nullptr);
    virtual ~MainWindow();
private:
    void replaceAccentedLetters(QString &input) const;

    Ui::MainWindow *ui;
    std::vector<QString> m_firstNameList;
    std::vector<QString> m_lastNameList;
};

#endif // MAINWINDOW_H
