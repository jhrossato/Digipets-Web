import { IMenu } from 'src/app/core/interfaces/IMenu';

export const compactNavigation: IMenu[] = [
  {
    text: 'Pet',
    icon: 'fa-solid fa-paw',
    routerLink: '',
    children: [
      {
        text: 'Adicionar Pet',
        routerLink: '/clientes/adicionar',
      },
      {
        text: 'Remover Pet',
        routerLink: '/clientes/adicionar',
      },
    ],
  },
  {
    text: 'Vacina',
    icon: 'fa-solid fa-syringe',
    routerLink: 'admin',
  },
  {
    text: 'Tutor',
    icon: 'fa-solid fa-user',
    routerLink: 'admin',
  },
];
