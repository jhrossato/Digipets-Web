import { ValidatorFn, AbstractControl } from '@angular/forms';



export const cpfValidator: ValidatorFn = (control: AbstractControl): { [key: string]: any } | null => {
  const cpf = control.value;

  // Remove caracteres especiais (pontos e traços) do CPF
  const cpfLimpo = cpf.replace(/[^\d]+/g, '');

  // Verifica se o CPF possui 11 dígitos
  if (cpfLimpo.length !== 11) {
    return { 'cpfInvalido': true };
  }

  // Verifica se todos os dígitos do CPF são iguais (CPF inválido)
  if (/^(\d)\1+$/.test(cpfLimpo)) {
    return { 'cpfInvalido': true };
  }

  // Calcula os dígitos verificadores do CPF
  let soma = 0;
  let resto;
  for (let i = 1; i <= 9; i++) {
    soma = soma + parseInt(cpfLimpo.substring(i - 1, i)) * (11 - i);
  }
  resto = (soma * 10) % 11;
  resto = (resto === 10 || resto === 11) ? 0 : resto;
  if (resto !== parseInt(cpfLimpo.substring(9, 10))) {
    return { 'cpfInvalido': true };
  }

  soma = 0;
  for (let i = 1; i <= 10; i++) {
    soma = soma + parseInt(cpfLimpo.substring(i - 1, i)) * (12 - i);
  }
  resto = (soma * 10) % 11;
  resto = (resto === 10 || resto === 11) ? 0 : resto;
  if (resto !== parseInt(cpfLimpo.substring(10, 11))) {
    return { 'cpfInvalido': true };
  }

  // Se o CPF passou por todas as validações, retorna null para indicar que é válido
  return null;
};



export const rgValidator: ValidatorFn = (control: AbstractControl): { [key: string]: any } | null => {
  const rg = control.value;

  // Remove caracteres especiais (pontos e traços) do RG
  const rgLimpo = rg.replace(/[^\d]+/g, '');

  // Verifica se o RG possui pelo menos 8 dígitos
  if (rgLimpo.length < 8) {
    return { 'rgInvalido': true };
  }

  // Verifica se todos os dígitos do RG são iguais (RG inválido)
  if (/^(\d)\1+$/.test(rgLimpo)) {
    return { 'rgInvalido': true };
  }

  // Se o RG passou por todas as validações, retorna null para indicar que é válido
  return null;
};


export const telefoneValidator: ValidatorFn = (control: AbstractControl): { [key: string]: any } | null => {
  const telefone = control.value;

  // Remove caracteres especiais (parênteses, traços e espaços) do telefone
  const telefoneLimpo = telefone.replace(/[\(\)\-\s]+/g, '');

  // Verifica se o telefone possui pelo menos 10 dígitos (9 dígitos do número + 2 dígitos do DDD)
  if (telefoneLimpo.length < 10) {
    return { 'telefoneInvalido': true };
  }

  // Se o telefone passou por todas as validações, retorna null para indicar que é válido
  return null;
};

export const celularValidator: ValidatorFn = (control: AbstractControl): { [key: string]: any } | null => {
  const celular = control.value;

  // Remove caracteres especiais (parênteses, traços e espaços) do celular
  const celularLimpo = celular.replace(/[\(\)\-\s]+/g, '');

  // Verifica se o celular possui pelo menos 11 dígitos (9 dígitos do número + 2 dígitos do DDD)
  if (celularLimpo.length < 11) {
    return { 'celularInvalido': true };
  }

  // Verifica se o nono dígito está presente, caso o celular tenha 11 dígitos
  if (celularLimpo.length === 11 && !/^[9]{1}\d{8}$/.test(celularLimpo)) {
    return { 'celularInvalido': true };
  }

  // Se o celular passou por todas as validações, retorna null para indicar que é válido
  return null;
};


export const senhaValidator: ValidatorFn = (control: AbstractControl): { [key: string]: any } | null => {
  const senha = control.value;

  // Verifica se a senha possui pelo menos 8 caracteres
  if (senha.length < 8) {
    return { 'senhaInvalida': true };
  }

  // Verifica se a senha possui pelo menos 1 letra maiúscula
  if (!/[A-Z]/.test(senha)) {
    return { 'senhaInvalida': true };
  }

  // Verifica se a senha possui pelo menos 1 letra minúscula
  if (!/[a-z]/.test(senha)) {
    return { 'senhaInvalida': true };
  }

  // Verifica se a senha possui pelo menos 1 número
  if (!/[0-9]/.test(senha)) {
    return { 'senhaInvalida': true };
  }

  // Verifica se a senha possui pelo menos 1 caractere especial
  if (!/[!@#$%^&*]/.test(senha)) {
    return { 'senhaInvalida': true };
  }

  // Se a senha passou por todas as validações, retorna null para indicar que é válida
  return null;
};



export const nomeValidator: ValidatorFn = (control: AbstractControl): {[key: string]: any} | null => {
  const nome = control.value;

  // Define o limite mínimo e máximo de caracteres para o nome (exemplo: mínimo de 3 e máximo de 50 caracteres)
  const minCaracteres = 3;
  const maxCaracteres = 50;

  // Verifica se o nome possui apenas caracteres alfabéticos
  if (!/^[a-zA-Z\s]*$/.test(nome)) {
    return {'nomeInvalido': true};
  }

  // Verifica se o nome possui pelo menos o número mínimo de caracteres
  if (nome.length < minCaracteres) {
    return {'nomeInvalido': true};
  }

  // Verifica se o nome ultrapassa o número máximo de caracteres permitido
  if (nome.length > maxCaracteres) {
    return {'nomeInvalido': true};
  }

  // Se o nome passou por todas as validações, retorna null para indicar que é válido
  return null;
};
