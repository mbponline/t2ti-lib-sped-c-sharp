/*******************************************************************************
Title: T2Ti ERP Fenix
Description: Model relacionado ao SPED Fiscal

The MIT License

Copyright: Copyright (C) 2020 T2Ti.COM

* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
* 
* The author may be contacted at: t2ti.com@gmail.com
*
@author Albert Eije (alberteije@gmail.com)
@version 1.0.0
*******************************************************************************/
namespace T2Ti.Lib.Sped.Fiscal
{
    public class Registro0300
    {
        public string codIndBem { get; set; } // Código individualizado do bem ou componente adotado no controle patrimonial do estabelecimento informante
        public int identMerc { get; set; } // Identificação do tipo de mercadoria
        public string descrItem { get; set; } // Descrição do bem ou componente (modelo, marca e outras características necessárias a sua individualização)
        public string codPrnc { get; set; } // Código de cadastro do bem principal nos casos em que o bem ou componente ( campo 02) esteja vinculado a um bem principal.
        public string codCta { get; set; } // Código da conta analítica de contabilização do bem ou componente (campo 06 do Registro 0500)
        public System.Nullable<System.Decimal> nrParc { get; set; } // Número total de parcelas a serem apropriadas, segundo a legislação de cada unidade federada
        public Registro0305 registro0305 { get; set; } // BLOCO 0 - Registro0305 (FILHO)
    }
}
