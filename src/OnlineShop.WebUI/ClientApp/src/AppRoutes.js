import { Counter } from './components/Counter';
import { FetchData } from './components/FetchData';
import ProductList from './products/ProductList';

const AppRoutes = [
  {
    index: true,
    element: <ProductList />,
  },
  {
    path: '/counter',
    element: <Counter />,
  },
  {
    path: '/fetch-data',
    element: <FetchData />,
  },
];

export default AppRoutes;
