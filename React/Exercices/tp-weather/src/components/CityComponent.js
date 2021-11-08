import { Col, Row } from "antd"

export const CityComponent = (props) => {
    return(
        <Row justify="center">
            <Col>
                {props.city}
            </Col>
        </Row>
    )
}