#include "kalkulator.h"
#include "ui_kalkulator.h"
#include <QMessageBox>

Kalkulator::Kalkulator(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::Kalkulator)
{
    ui->setupUi(this);
    calLogic = new CalculatorLogic();

    connect(ui->btn0,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btn1,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btn2,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btn3,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btn4,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btn5,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btn6,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btn7,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btn8,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btn9,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnMnozenje,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnDelete,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnDeljenje,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnKoren,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnOduzimanje,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnSabiranje,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnClear,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnZarez,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnZnak,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnJednako,SIGNAL(clicked()),this,SLOT(onBtnClicked()));

    connect(calLogic,SIGNAL(resultChanged(QString)),this,SLOT(onResultChanged(QString)));
    connect(calLogic,SIGNAL(resultHistoryChanged(QString)),this,SLOT(onResultHistoryChanged(QString)));


}

Kalkulator::~Kalkulator()
{
    delete ui;
}

void Kalkulator::onBtnClicked()
{
    QObject *pom = sender();
    QString text = ((QPushButton*)pom)->text();
    calLogic->doCommand(text);

}
void Kalkulator::onResultChanged(QString s)
{
    ui->lneDisplej->setText(s);
}
void Kalkulator::onResultHistoryChanged(QString s)
{
    ui->pteIstorija->appendPlainText(s);
}
