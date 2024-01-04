import Header from "../Header"
import Section1 from "./Section1"
import Aboutus from "./Aboutus"
import Subscripe from "./subscripe"
import Footer from "../Footer"
import PopularePrdcts from './PopularePrdcts'
import NewListings from "./NewListings"

export default function Homecomp() {
  return (
    <>
      <Header></Header>
      <Section1></Section1>
      <PopularePrdcts></PopularePrdcts>
      <NewListings></NewListings>
      <Aboutus></Aboutus>
      <Subscripe></Subscripe>
      <Footer></Footer>
    </>
  )
}
