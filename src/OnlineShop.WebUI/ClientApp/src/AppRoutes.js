import { Counter } from './components/Counter';
import { FetchData } from './components/FetchData';
import ProductDetails from './products/ProductDetails';
import ProductList from './products/ProductList';

const AppRoutes = [
  {
    index: true,
    element: <ProductList />,
  },
  {
    path: '/product/:id',
    element: <ProductDetails />,
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
