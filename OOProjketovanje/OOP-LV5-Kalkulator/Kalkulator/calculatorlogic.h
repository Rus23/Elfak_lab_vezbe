#ifndef CALCULATORLOGIC_H
#define CALCULATORLOGIC_H

#include <QObject>
#include <QMessageBox>

class CalculatorLogic : public QObject
{
    Q_OBJECT
private:
    QString izraz="";
    QString rezultat="";
    QString prviOperand="";
    QString drugiOperand="";
    QString operacija="";

public:
    explicit CalculatorLogic(QObject *parent = nullptr);
    void doCommand(QString s);

signals:
    void resultChanged(QString);
    void resultHistoryChanged(QString);

public slots:

};

#endif // CALCULATORLOGIC_H
