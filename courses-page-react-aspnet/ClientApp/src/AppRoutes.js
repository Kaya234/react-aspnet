import HomePage from "./components/Home/HomePage";
import CoursePage from "./components/CourseList/CoursePage";
import CourseDetail from "./components/CourseList/CourseDetail";
import Search from "./components/Search/Search";
import Category from "./components/Category/Category";

const AppRoutes = [
  {
    index: true,
    element: <HomePage />
  },
  {
    path: '/courses',
    element: <CoursePage />
  },
  {
    path: '/courses/:id',
    element: <CourseDetail />
  },
  {
    path: '/search',
    element: <Search />
  },
  {
    path: '/categories',
    element: <Category />
  }
];

export default AppRoutes;
