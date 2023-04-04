import { IMenu } from 'src/app/core/interfaces/IMenu';

export const compactNavigation: IMenu[] = [
  {
    text: 'Pet',
    icon: 'fa-solid fa-paw',
    routerLink: '',
    children: [
      {
        text: 'Adicionar Pet',
        routerLink: 'pet',
      },
      {
        text: 'Remover Pet',
        routerLink: '/pet/remover',
      },
    ],
  },
  {
    text: 'Vacina',
    icon: 'fa-solid fa-syringe',
    routerLink: 'vacina',
  },
  {
    text: 'Tutor',
    icon: 'fa-solid fa-user',
    routerLink: 'tutor',
  },
];
