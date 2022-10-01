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
];

export default AppRoutes;
