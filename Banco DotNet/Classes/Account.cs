using System;

namespace BancoDN
{
    class Account
    {
        int _id;
        TypeA _type {get; set;}
        double _money {get; set;}
        double _credit {get; set;}
        string _name {get; set;}

        public Account(int _tempID, TypeA _tempType, double _tempMoney, double _tempCredit, string _tempName)
        {
            _id = _tempID;
            _type = _tempType;
            _money = _tempMoney;
            _credit = _tempCredit;
            _name = _tempName;
        }

        public string Draw(double _value)
        {
            if (_money >= _value)
            {
                _money -= _value;
                return "Saque realizado com sucesso!!";
                GetSaldo();
            }
            else
            {
                return "Saldo indisponível!!";
            }
        }

        public string Transfer(double _value, Account _toAccount)
        {
            if (_money >= _value)
            {
                _money -= _value;
                _toAccount.Deposit(_value);
                return "Transferência realizada com sucesso!!";
            }
            else
            {
                return "Saldo indisponível!!";
            }
        }

        public string GetSaldo()
        {
            return $"Seu saldo atual é de { _money.ToString("C2")}";
        }

        public string Deposit(double _value)
        {
           _money += _value;
            return $"Deposito de {_value.ToString("C2")} realizado com sucesso";
        }

        public override string ToString()
        {
            string _info = "";
            _info += $"Tipo Conta: {_type} | ";
            _info += $"Nome: {_name} | ";
            _info += $"Saldo: {_money.ToString("C2")} | ";
            //_info += $" {} | ";
            return _info;
        }
    }
} 