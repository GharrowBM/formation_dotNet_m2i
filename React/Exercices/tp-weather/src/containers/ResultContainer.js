import { PureComponent } from "react";
import { connect } from "react-redux";
import { Card, Col, Row } from "antd"
import { CityComponent } from "../components/CityComponent";
import { IconComponent } from "../components/IconComponent";
import { TempComponent } from "../components/TempComponent";
class ResultContainer extends PureComponent {
    constructor(props) {
        super(props);
        this.state = {}
    }
    componentDidMount() {
        //Code sera executé aprés le premier rendu du composant
        //Ici on appelle par exemple les API au démarrage du composant
    }
    // shouldComponentUpdate(nextProps, nextState) {
    //     return nextProps != this.props || nextState != this.state
    // }
    componentDidUpdate() {
        //Code executé à la fin de chaque mise à jour.
    }
    render() {
        return (
            <Row justify="center">
                <Col span={10}>
                    {this.props.weather != undefined ? (
                        <Card>
                            <CityComponent city={this.props.weather.name} />
                            {this.props.weather.weather.map((w) => (
                                <IconComponent description={w.description} icon={`http://openweathermap.org/img/wn/${w.icon}@2x.png`}></IconComponent>
                            ))}
                            <TempComponent main={this.props.weather.main}></TempComponent>
                        </Card>
                    ) : null}
                </Col>
            </Row>
        );
    }
}
const mapStateToProps = (state) => {
    return {
        weather: state.weather.weather,
        error: state.weather.error
    }
}
export default connect(mapStateToProps, null)(ResultContainer);