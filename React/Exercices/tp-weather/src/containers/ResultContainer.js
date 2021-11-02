import { PureComponent } from "react";
import { connect } from "react-redux";
import { Card, Col, Row } from "antd"
import { CityComponent } from "../components/CityComponent";
import { IconComponent } from "../components/IconComponent";
class ResultContainer extends PureComponent {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <Row justify="center">
                <Col>
                    {this.props.weather != undefined ? (
                        <Card>
                            <CityComponent city={this.props.weather.name} />
                            {this.props.weather.weather.map((w) => (
                                <IconComponent icon={`http://openweathermap.org/img/wn/${w.icon}@2x.png`}></IconComponent>
                            ))}
                            {this.props.weather.main.temp}
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