#ifndef KALKULATOR_H
#define KALKULATOR_H

#include <QWidget>
#include "calculatorlogic.h"

namespace Ui {
class Kalkulator;
}

class Kalkulator : public QWidget
{
    Q_OBJECT

public:
    explicit Kalkulator(QWidget *parent = 0);
    ~Kalkulator();

private slots:
    void onBtnClicked();
    void onResultChanged(QString);
    void onResultHistoryChanged(QString);

private:
    Ui::Kalkulator *ui;
    CalculatorLogic *calLogic;
};

#endif // KALKULATOR_H
