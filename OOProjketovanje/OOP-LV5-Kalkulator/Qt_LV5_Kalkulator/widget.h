#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>
#include <calculatorlogic.h>

namespace Ui {
class Widget;
}

class Widget : public QWidget
{
    Q_OBJECT

public:
    explicit Widget(QWidget *parent = 0);
    ~Widget();

private slots:

    void onBtnClicked();
    void onResultChanged(QString);
    void onResultHistoryChanged(QString);



private:
    Ui::Widget *ui;
    CalculatorLogic *kalkulator;

    void setAllBtnExpanding();
    void poveziBtnSaSlotovima();
};

#endif // WIDGET_H
